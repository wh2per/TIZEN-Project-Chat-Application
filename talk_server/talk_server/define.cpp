#include "define.h"

char* content_recv_buffer=NULL;	//메시지를 받으면 여기에 content가 저장
char* content_send_buffer=NULL;	//메시지를 보내기 전에 임시로 content를 담기위해 활용
fd_set reads, temps;	//멀티플렉싱을 위해

map<int, ROOM*> room;		//방 정보를 저장
map<int, SOCKET> sock;		//클라이언트들의 소켓을 저장
map<int, ROOM*>::iterator room_iter;//방정보 이터레이터
map<int,SOCKET>::iterator sock_iter;//소켓 이터레이터

queue<MESSAGE*> msg_queue;
MESSAGE msg_recv;
