#include "define.h"

char* content_recv_buffer=NULL;	//�޽����� ������ ���⿡ content�� ����
char* content_send_buffer=NULL;	//�޽����� ������ ���� �ӽ÷� content�� ������� Ȱ��
fd_set reads, temps;	//��Ƽ�÷����� ����

map<int, ROOM*> room;		//�� ������ ����
map<int, SOCKET> sock;		//Ŭ���̾�Ʈ���� ������ ����
map<int, ROOM*>::iterator room_iter;//������ ���ͷ�����
map<int,SOCKET>::iterator sock_iter;//���� ���ͷ�����

queue<MESSAGE*> msg_queue;
MESSAGE msg_recv;
