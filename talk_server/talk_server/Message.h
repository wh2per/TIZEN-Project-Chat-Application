#ifndef _MESSAGE_H_
#define _MESSAGE_H_
class MESSAGE{
public:
	int type;
	int sender;
	int etc;		//메세지 보낼땐 시간, 방 만들때는 사람 숫자
	int room_idx;
	int content_size;
	char* content_buffer;
	int setBuffer(int type, int sender, int etc, int room_idx, char* content,int content_size);
	void setMessage(int type, int sender, int etc, int room_idx, char* content,int content_size);
	void handleMessage();
};

#endif