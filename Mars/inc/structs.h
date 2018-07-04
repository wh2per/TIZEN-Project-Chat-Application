#ifndef _STRUCTS_H_
#define _STRUCTS_H_

typedef struct Message{
	int type;
	int sender;
	int etc;
	int room_idx;
	int content_size;
}MESSAGE;

typedef struct user_info{
	int idx;
	char name[32];
}USER_INFO;


typedef struct Room{
	int room_idx;
	int user_list_size;
	int user_list_num;
	USER_INFO *user_list;
}ROOM;


typedef struct chat{
	int msg_idx;
	int sender_idx;
	int time;
	char* content;
}CHAT;


typedef struct ListNode{
	CHAT msg;
	struct ListNode *Before;
	struct ListNode *After;
}ListNode;

typedef struct List
{
	ListNode *header;
	ListNode *tailer;
}HISTORY;

#endif /* structs_h */
