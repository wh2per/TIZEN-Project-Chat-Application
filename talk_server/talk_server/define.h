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



extern fd_set reads, temps;	//��Ƽ�÷����� ����
extern char* content_recv_buffer;	//�޽����� ������ ���⿡ content�� ����
extern char* content_send_buffer;	//�޽����� ������ ���� �ӽ÷� content�� ������� Ȱ��

#include "Room.h"

extern map<int, ROOM*> room;		//�� ������ ����
extern map<int, SOCKET> sock;		//Ŭ���̾�Ʈ���� ������ ����
extern map<int, ROOM*>::iterator room_iter;//������ ���ͷ�����
extern map<int,SOCKET>::iterator sock_iter;//���� ���ͷ�����


#include "Message.h"

extern queue<MESSAGE*> msg_queue;
extern MESSAGE msg_recv;



#endif