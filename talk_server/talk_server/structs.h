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
	int etc;		//메세지 보낼땐 시간, 방 만들때는 사람 숫자
	int room_idx;
	int content_size;
}MESSAGE;
#endif
