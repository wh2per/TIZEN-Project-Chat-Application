#include "Message.h"
#include "define.h"

#include "general_helper.h"
#include "message_helper.h"


int MESSAGE::setBuffer(int type, int sender, int etc, int room_idx, char* content,int content_size)
{
	int content_real_size;
	int nextMsgIdx;
	this->content_buffer=(char*)malloc(content_size);
	memcpy(this->content_buffer,content,content_size);
	if(type==0)
	{
		nextMsgIdx=getNextMsgIdx(this->room_idx);
		memcpy(this->content_buffer+content_size-4,&nextMsgIdx,4);
	}
	return content_size;
}

void MESSAGE::setMessage(int type, int sender, int etc, int room_idx, char* content,int content_size)
{
	this->type=type;
	this->sender=sender;
	this->etc=etc;
	this->room_idx=room_idx;
	setBuffer(type,sender,etc,room_idx,content,content_size);
	this->content_size=content_size;
}

void MESSAGE::handleMessage()
{	
	int new_room_idx=-1;
	char* content=NULL;
	char id[32];
	char pw[32];
	char name[32];
	char email[128];
	char auth_key[32];
	char phone[32];
	__time32_t timestamp;
	vector<int> user_list;
	vector<int>::iterator user_list_iter;
	int temp_int;
	int* temp_int_arr;

	int room_user_count;
	int errorcode;
	int sender_idx=-1;
	int nextMsgIdx;

	switch(type)
	{
	case MSG_TALK:
		timestamp=time(NULL);
		nextMsgIdx=getNextMsgIdx(this->room_idx);
		content=(char*)malloc(this->content_size+1);
		memcpy(content,this->content_buffer,this->content_size);
		content[this->content_size]=0;
		storeMessage(nextMsgIdx,this->room_idx,sender,content,timestamp);
		free(content);
		content=(char*)malloc(this->content_size+4);
		memcpy(content,this->content_buffer,this->content_size);
		memcpy(content+this->content_size,&nextMsgIdx,4);
		sendRoomMessage(this->room_idx,MSG_TALK ,this->sender,timestamp,this->room_idx,content, this->content_size+4);
		free(content);
		break;


	case MSG_ROOMCREATE:
		new_room_idx=createRoom();
		content=(char*)malloc((this->etc+1)*36);
		room_iter=room.find(new_room_idx);

		for(int i=0;i<this->etc;i++)
		{
			addUser(new_room_idx,*((int*)(content_buffer+(i*4))));
			memcpy(content+(i*36),((int*)(content_buffer+(i*4))),4);
			getUserName(room_iter->second->user[i],name);
			memcpy(content+4+(i*36),name,32);
		}
		addUser(new_room_idx,this->sender);
		*(int*)(content+(this->etc*36))=this->sender;
		getUserName(this->sender,name);
		memcpy(content+4+(this->etc*36),name,32);
		sendRoomMessage(new_room_idx,MSG_ROOMCREATE ,NULL,this->etc+1,new_room_idx,content, (this->etc+1)*36);
		break;

	case MSG_USERREGISTER:
		memcpy(id,this->content_buffer,32);
		memcpy(pw,this->content_buffer+32,32);
		memcpy(name,this->content_buffer+64,32);
		memcpy(email,this->content_buffer+96,128);
		memcpy(phone,this->content_buffer+224,32);
		if(errorcode=regUser(id,pw,name,email,phone)!=0)
		{
			printf("regUser() error");
		}
		sendSockMessage((SOCKET)this->etc,MSG_USERREGISTER ,NULL,errorcode,NULL,NULL, 0); 

		//여기에서 이메일로 인증키 보내줄것!!!!

		break;

	case MSG_LOGIN :
		memcpy(id,this->content_buffer,32);
		memcpy(pw,this->content_buffer+32,32);
		sender_idx=loginCheck(id,pw,(SOCKET)this->etc);
		if(sender_idx==-1)
		{
			errorcode=-1;
			sendSockMessage((SOCKET)this->etc,MSG_LOGIN ,sender_idx,errorcode,NULL,NULL, 0);
		}
		else
		{
			if(isAuthed(sender_idx,0))
			{
				errorcode=0;
				sendSockMessage((SOCKET)this->etc,MSG_LOGIN ,sender_idx,errorcode,NULL,NULL, 0);
				temp_int=getRoomCount(sender_idx);
				temp_int_arr=(int*)malloc(temp_int*4);
				getRoomList(sender_idx,temp_int_arr);
				for(int i=0;i<temp_int;i++)
				{
					room_iter=room.find(temp_int_arr[i]);
					room_user_count=room_iter->second->user.size();
					content=(char*)malloc((room_user_count)*36);
					getUserList(temp_int_arr[i],content);
					sendUserMessage(sender_idx,MSG_ROOMCREATE ,NULL,room_user_count,temp_int_arr[i],content,(room_user_count)*36);
					free(content);
				}
				free(temp_int_arr);
			}
			else
			{
				errorcode=-2;
				sendSockMessage((SOCKET)this->etc,MSG_LOGIN ,sender_idx,errorcode,NULL,NULL, 0);
			}
		}
		break;

	case MSG_FRIENDINFO:
		this->etc=getFriendCount(this->sender);
		printf("%d",this->etc);
		content=(char*)malloc(this->etc*36);
		sendUserMessage(this->sender,MSG_FRIENDINFO ,this->sender,getFriendList(this->sender,content),NULL,content, this->etc*36);
		break;

	case MSG_FRIENDADD:
		content=(char*)malloc(36);
		memset(content,0,36);
		temp_int=getUserIdx(this->content_buffer);
		memcpy(content,&temp_int,4);
		getUserName(temp_int,content+4);
		sendUserMessage(this->sender,MSG_FRIENDADD ,this->sender,addFriend(sender,temp_int),NULL,content,36);
		break;

	case MSG_HISTORY:
		handleHistoryRequest(this->room_idx,this->etc,this->sender);
		break;

	case MSG_PWRESET:
		
		if(isAuthed(this->sender,1))
		{
			memcpy(pw,this->content_buffer,32);
			resetPassword(this->sender,pw);
			sendUserMessage(this->sender,MSG_PWRESET,NULL,0,NULL,NULL,NULL);
		}
		else
			sendUserMessage(this->sender,MSG_PWRESET,NULL,-1,NULL,NULL,NULL);

	case MSG_AUTHCHECK:
		memcpy(id,this->content_buffer,32);
		memcpy(auth_key,this->content_buffer+32,32);
		memcpy(&temp_int,this->content_buffer+64,4);
		if(authenticate(getUserIdx(id),temp_int,auth_key)==0)
		{
			sendSockMessage(this->etc,MSG_AUTHCHECK,NULL,0,NULL,NULL,NULL);
		}
		else
		{
			sendSockMessage(this->etc,MSG_AUTHCHECK,NULL,-1,NULL,NULL,NULL);
		}

	}
}