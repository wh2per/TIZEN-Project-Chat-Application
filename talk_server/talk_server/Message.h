#ifndef _MESSAGE_H_
#define _MESSAGE_H_
class MESSAGE{
public:
	int type;
	int sender;
	int etc;		//�޼��� ������ �ð�, �� ���鶧�� ��� ����
	int room_idx;
	int content_size;
	char* content_buffer;
	int setBuffer(int type, int sender, int etc, int room_idx, char* content,int content_size);
	void setMessage(int type, int sender, int etc, int room_idx, char* content,int content_size);
	void handleMessage();
};

#endif