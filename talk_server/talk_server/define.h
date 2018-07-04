#ifndef _DEFINE_H_
#define _DEFINE_H_

#include <WinSock2.h>
#include <stdio.h>
#include <map>
#include <vector>
#include <queue>
#include <time.h>
#include <mysql.h>
#include <stdlib.h>
#include <string.h>
#include <process.h>

using namespace std;

#define DB_HOST "127.0.0.1"
#define DB_USER "root"
#define DB_PASS "apmsetup"
#define DB_NAME "my_talk"
#define HEADERSIZE 20

#define MSG_TALK 0
#define MSG_ROOMCREATE 1
#define MSG_USERREGISTER 2
#define MSG_LOGIN 3
#define MSG_FRIENDINFO 4
#define MSG_FRIENDADD 5
#define MSG_HISTORY 6
#define MSG_ROOMEXIT 7
#define MSG_PWRESET 12
#define MSG_AUTHCHECK 14



extern fd_set reads, temps;	//멀티플렉싱을 위해
extern char* content_recv_buffer;	//메시지를 받으면 여기에 content가 저장
extern char* content_send_buffer;	//메시지를 보내기 전에 임시로 content를 담기위해 활용

#include "Room.h"

extern map<int, ROOM*> room;		//방 정보를 저장
extern map<int, SOCKET> sock;		//클라이언트들의 소켓을 저장
extern map<int, ROOM*>::iterator room_iter;//방정보 이터레이터
extern map<int,SOCKET>::iterator sock_iter;//소켓 이터레이터


#include "Message.h"

extern queue<MESSAGE*> msg_queue;
extern MESSAGE msg_recv;



#endif