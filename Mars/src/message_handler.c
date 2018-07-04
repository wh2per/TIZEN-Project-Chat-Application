#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <semaphore.h>

#include "define.h"
#include "function.h"
#include "message_handler.h"
#include "message_bubble.h"

int setBuffer(int type, int sender, int etc, int room_idx, char* content)
{
    int content_real_size=0;
    switch(type)
    {
        case 0:     //메세지 보내기
            content_real_size=((int)strlen(content));
            break;
        case 1:     //방만들기 결과
            content_real_size=4*etc;
            break;
        case 2:     //회원가입 확인
            content_real_size=96;
            break;
        case 3:     //로그인 확인
            content_real_size=64;
            break;
        case 4:     //친구정보 확인
            content_real_size=0;
            break;
        case 5:     //친구추가 확인
            content_real_size=32;
            break;
        case 6:     //대화히스토리 요청
            content_real_size=0;
            break;

    }

    content_send_buffer=(char*)malloc(content_real_size);
    memcpy(content_send_buffer,content,content_real_size);
    return content_real_size;
}

void setMessage(int type, int sender, int etc, int room_idx, char* content)
{
    msg_send.type = type;
    msg_send.sender=sender;
    msg_send.etc=etc;
    msg_send.room_idx=room_idx;
    msg_send.content_size=setBuffer(type,sender,etc,room_idx,content);
}

void sendMessage(int type, int sender, int etc, int room_idx, char* content)
{
    setMessage(type, sender, etc, room_idx, content);
    char* send_buffer;
    send_buffer=(char*)malloc(msg_send.content_size+HEADERSIZE);

    memcpy(send_buffer, &msg_send, HEADERSIZE);
    memcpy(send_buffer+HEADERSIZE,content_send_buffer,msg_send.content_size);

    write(sock, send_buffer,msg_send.content_size+HEADERSIZE);
    free(send_buffer);
    free(content_send_buffer);
}

void recvMessage()
{
    int strLen=0;
    int bufLen=0;
    char* recv_buffer=(char*)malloc(HEADERSIZE);

    while(strLen<HEADERSIZE)
    {
        bufLen=(int)read(sock, recv_buffer,HEADERSIZE-strLen);
        strLen+=bufLen;
    }

    memcpy(&msg_recv,recv_buffer,HEADERSIZE);
    free(recv_buffer);
    recv_buffer=(char*)malloc(msg_recv.content_size);

    while(strLen<msg_recv.content_size+HEADERSIZE)
    {
        bufLen=(int)read(sock, recv_buffer,(msg_recv.content_size-strLen+HEADERSIZE));
        strLen+=bufLen;
    }

    content_recv_buffer=(char*)malloc(msg_recv.content_size);
    memcpy(content_recv_buffer,recv_buffer,msg_recv.content_size);
    free(recv_buffer);
}

void handleMessage()
{
	int type=msg_recv.type;
	int sender=msg_recv.sender;
	int etc=msg_recv.etc;
	char* content=(char*)malloc(msg_recv.content_size);
	memcpy(content,content_recv_buffer,msg_recv.content_size);
	int room_idx=msg_recv.room_idx;

	ROOM room_temp;

	switch(type)
	{
		case MSG_TALK:    //
			if(current_room!=-1 && current_room==room_idx)
			{
				content_recv_buffer[msg_recv.content_size-4]=0;
				load_messages();
				sem_wait(&sem_load_message);
			}
			else
			{
				printf("새 메시지 도착!");
				//팝업 처리 해줄것! 새로운 메시지 도착 알림
			}
			break;

		case MSG_ROOMCREATE:
			AppendRoom();
			//DumpRoomArray("Room Status");
			AppendRoomUser(RoomSearch(msg_recv.room_idx));
			//DumpRoomUserArray("RoomUser Status",room_list_num-1);
			sem_post(&sem_room_list);
			break;
		case MSG_USERREGISTER:
			if(etc==0)
			{

			}
			else
			{
				printf("error : %d", etc);
			}
			break;

		case MSG_LOGIN:
			if(etc==0)
			{
				my_index=sender;
				InitRoomArray(1);
				InitFriendArray(1);
				HistoryInit(&chat_memory);
				flag = 1;
				sem_post(&sem_login);
			}
			else if(etc==-1)
			{
				printf("ID가 없어\n");
			}
			else if(etc==-2)
			{
				printf("인증이 안됬다\n");
			}
			else
			{
			}
			break;

		case MSG_FRIENDINFO:
			AppendFriend(msg_recv.etc);
			sem_post(&sem_friend_list);
			break;

		case MSG_FRIENDADD:
			if(etc!=0)
			{
				printf("error : %d",etc);
			}
			else
				AppendFriend(1);
			break;

		case MSG_HISTORY:
			Push_Back(&chat_memory);
			Printing(&chat_memory);
			break;
		case MSG_ROOMEXIT:	//방나가기
			current_room = -1;
			break;
		case MSG_ROOMUSERADD: //방에서 유저 추
			break;
		case MSG_IDSEARCH: //아이디찾기
			if(etc==0){

			}
				//가능
			else{}
				//불가
			break;
		case MSG_PWSEARCH: //비밀번호 찾기

			break;
		case MSG_IDDUPLICATE: //아이디 중복확인
			if(etc==0)
			{}//가능
			else
			{}//불가
			break;
		case MSG_PWRESET: //비밀번호 재설
			if(etc==0)
			{}	//성공
			else
			{}	//실패
			break;
		case MSG_AUTHREQUEST: //인증번호 요
			if(etc==0)
			{}	//성공
			else
			{}	//실패
 			break;
		case MSG_AUTHCHECK:
			if(etc==0)
			{
				flag=1;
			}
			else
			{
				printf("인증실패다\n");
			}
			break;
	}

	free(content_recv_buffer);
}
