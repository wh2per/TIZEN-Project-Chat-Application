#ifndef _STRUCTS_H_
#define _STRUCTS_H_
#include <WinSock2.h>



typedef struct Room{
	bool exists;
	int room_idx;
	int user_idx[20];
	int user_count;
}ROOM;


typedef struct Message{
	int type;
	int sender;
	int etc;		//�޼��� ������ �ð�, �� ���鶧�� ��� ����
	int room_idx;
	int content_size;
}MESSAGE;
#endif
