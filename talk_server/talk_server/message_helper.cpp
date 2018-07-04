#include "message_helper.h"
#include "define.h"
#include "general_helper.h"

int recvMessage(SOCKET sock)
{
	int strLen=0;
	int bufLen=0;
	char* recv_buffer=(char*)malloc(HEADERSIZE);

	while(strLen<HEADERSIZE)
	{
		bufLen=recv(sock, recv_buffer, HEADERSIZE-strLen, 0);	
		if(bufLen==-1)
			return -1;
		strLen+=bufLen;	
	}

	memcpy(&msg_recv,recv_buffer,HEADERSIZE);
	free(recv_buffer);
	recv_buffer=(char*)malloc(msg_recv.content_size);

	while(strLen<msg_recv.content_size+HEADERSIZE)
	{
		bufLen=recv(sock,recv_buffer,(msg_recv.content_size-strLen+HEADERSIZE),0);
		strLen+=bufLen;	
	}
	msg_recv.content_buffer=(char*)malloc(msg_recv.content_size);
	memcpy(msg_recv.content_buffer,recv_buffer,msg_recv.content_size);
	free(recv_buffer);
	return 0;
}

void sendSockMessage(SOCKET sock, int type, int sender, int etc, int room_idx, char* content, int content_size)
{
	char* send_buffer;
	MESSAGE msg_send;
	msg_send.setMessage(type, sender, etc, room_idx, content,content_size);
	send_buffer=(char*)malloc(content_size+HEADERSIZE);

	memcpy(send_buffer, &msg_send, HEADERSIZE);
	memcpy(send_buffer+HEADERSIZE,msg_send.content_buffer,msg_send.content_size);

	send(sock, send_buffer,content_size+HEADERSIZE, 0);
	free(send_buffer);
	free(msg_send.content_buffer);
}

void sendUserMessage(int user_idx, int type, int sender, int etc, int room_idx, char* content, int content_size)
{
	SOCKET user_sock;
	char* send_buffer;
	MESSAGE msg_send;
	msg_send.setMessage(type, sender, etc, room_idx, content,content_size);
	send_buffer=(char*)malloc(msg_send.content_size+HEADERSIZE);
	sock_iter=sock.find(user_idx);
	if(sock_iter!=sock.end())
		user_sock=sock_iter->second;

	else
	{
		printf("잘못된 유저 인덱스를 sendUserMessage로 전달");
		return;
	}


	memcpy(send_buffer, &msg_send, HEADERSIZE);
	memcpy(send_buffer+HEADERSIZE,msg_send.content_buffer,msg_send.content_size);



	send(user_sock, send_buffer,msg_send.content_size+HEADERSIZE, 0);
	free(send_buffer);
	free(msg_send.content_buffer);
}

void sendRoomMessage(int send_room_idx, int type, int sender, int etc, int room_idx, char* content, int content_size)
{
	SOCKET user_sock;
	ROOM* send_room;
	send_room=findRoom(send_room_idx);

	if(send_room==NULL)
	{
		printf("존재하지 않는 방번호가 sendRoomMessage로 전달됨");
		return;
	}
	if(send_room->user.size()==0)
	{
		printf("방에 유저가 존재하지 않음");
		return;
	}


	for(int i=0;i<send_room->user.size();i++)
	{
		sendUserMessage(send_room->user[i],type,sender,etc,room_idx,content, content_size);
	}

}


int handleHistoryRequest(int room_idx, int etc, int sender)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result_idx;
	MYSQL_RES *sql_result_name;
	MYSQL_ROW sql_row;
	char sql[500];
	char* buffer;
	MESSAGE msg_tmp;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");

	if(etc==-1)
		sprintf(sql,"select * from talk_history where room_idx=%d order by msg_idx desc limit 10",room_idx);
	else
		sprintf(sql,"select * from talk_history where room_idx=%d and msg_idx<%d order by msg_idx desc limit 10",room_idx, etc);
	query_stat=mysql_query(connection, sql);
	sql_result_idx=mysql_store_result(connection);



	while(sql_row=mysql_fetch_row(sql_result_idx))
	{
		int i=atoi(sql_row[0]);
		buffer=(char*)malloc(strlen(sql_row[3])+3);
		memcpy(buffer,sql_row[3],strlen(sql_row[3])-1);
		memcpy(buffer+strlen(sql_row[3])-1,&i,4);
		sendUserMessage(sender,MSG_HISTORY,atoi(sql_row[2]),atoi(sql_row[4]),atoi(sql_row[1]),buffer, sizeof(buffer));
		free(buffer);
	}

	mysql_free_result(sql_result_idx);
	mysql_close(connection);
	return 0;
}