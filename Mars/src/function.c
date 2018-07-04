#include "function.h"
#include "define.h"
#include "structs.h"

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void InitRoomArray(int asize)
{
	room_list_size = asize;
	room_list_num = 0;
	rooms = (ROOM*)malloc(room_list_size*sizeof(ROOM));
}

void InitFriendArray(int asize)
{
	friend_list_size = asize;
	friend_list_num = 0;
	friend_list = (USER_INFO*)malloc(friend_list_size*sizeof(USER_INFO));
}

void InitRoomUserArray(int asize, int room_idx)
{
	rooms[room_idx].user_list_size = asize;
	rooms[room_idx].user_list_num = 0;
	rooms[room_idx].user_list = (USER_INFO*)malloc(rooms[room_idx].user_list_size*sizeof(USER_INFO));
}

void InsertRoom(int idx)
{
	int need;

	need = room_list_num+1;
	if(need>room_list_size)
	{
		room_list_size = need;
		rooms = (ROOM*)realloc(rooms, room_list_size*sizeof(ROOM));
	}
	memmove(rooms+idx+1, rooms+idx, (room_list_num-idx)*sizeof(ROOM));
	rooms[idx].room_idx = msg_recv.room_idx;
	InitRoomUserArray(msg_recv.etc,idx);
	room_list_num++;
}


void InsertFriend(int idx, int count)
{
	int need;
	int i;

	need = friend_list_num+count;

	if(need>friend_list_size)
	{
		friend_list_size = need;
		friend_list = (USER_INFO*)realloc(friend_list, friend_list_size*sizeof(USER_INFO));
	}
	memmove(friend_list+idx+1, friend_list+idx, (friend_list_num-idx)*sizeof(USER_INFO));

	for(i=0; i<count; i++)
	{
		friend_list[idx+i].idx = *(content_recv_buffer+(i*36));
		memcpy(friend_list[idx+i].name, content_recv_buffer+4+(i*36), 32);
		friend_list_num++;
	}
}

void InsertRoomUser(int idx, int room_idx)
{
	int need;
	int i;

	need = rooms[room_idx].user_list_num + msg_recv.etc;

	if(need>rooms[room_idx].user_list_size)
	{
		rooms[room_idx].user_list_size= need;
		rooms[room_idx].user_list = (USER_INFO*)realloc(rooms[room_idx].user_list, rooms[room_idx].user_list_size*sizeof(USER_INFO));
	}
	memmove(rooms[room_idx].user_list+idx+msg_recv.etc, rooms[room_idx].user_list+idx, (rooms[room_idx].user_list_num-idx)*sizeof(USER_INFO));

	for(i=0; i<msg_recv.etc; i++)
	{
		rooms[room_idx].user_list[idx+i].idx = *(content_recv_buffer+(i*36));
		memcpy(rooms[room_idx].user_list[idx+i].name, content_recv_buffer+4+(i*36), 32);
		rooms[room_idx].user_list_num++;
	}
}


void DeleteRoom(int idx)
{
	memmove(rooms+idx, rooms+idx+1, (room_list_num-idx-1)*sizeof(ROOM));
	room_list_num--;
}

void DeleteFriend(int idx)
{
	memmove(friend_list+idx, friend_list+idx+1, (friend_list_num-idx-1)*sizeof(USER_INFO));
	friend_list_num--;
}

void DeleteRoomUser(int idx, int room_idx)
{
	memmove(rooms[room_idx].user_list+idx, rooms[room_idx].user_list+idx+1, (rooms[room_idx].user_list_num-idx-1)*sizeof(USER_INFO));
	rooms[room_idx].user_list_num--;
}


void AppendRoom()
{
	InsertRoom(room_list_num);
}

void AppendFriend(int count)
{
	InsertFriend(friend_list_num, count);
}

void AppendRoomUser(int room_idx)
{
	InsertRoomUser(rooms[room_idx].user_list_num, room_idx);
}


void UnInitRoomArray()
{
	free(rooms);
}

void UnInitFriendArray()
{

	free(friend_list);
}

void UnInitRoomUserArray(int room_idx)
{
	free(rooms[room_idx].user_list);
}

void DumpRoomArray(char *sMark)
{
	int i;
	printf("%16s => size=%02d, num=%02d ", sMark, room_list_size, room_list_num);
	printf("\n");
	for(i=0; i<room_list_num; i++)
	{
		printf("Room Num : %02d ", rooms[i].room_idx);
	}
	printf("\n\n\n");
}

void DumpFriendArray(char *sMark)
{
	int i;
	printf("%16s = > size=%02d, num=%02d", sMark, friend_list_size, friend_list_num);
	printf("\n");

	for(i=0; i<friend_list_num; i++)
	{
		printf("name : %02s ", friend_list[i].name);
		printf("index : %02d ", friend_list[i].idx);
		printf("\n");
	}
	printf("\n\n");
}

void DumpRoomUserArray(char *sMark, int room_idx)
{
	int i,j;

	for(i=0; i<room_list_num; i++)
	{
		printf("%16s = > size=%02d, num=%02d", sMark, rooms[i].user_list_size, rooms[i].user_list_num);
		printf("\n");

		for(j=0; j<rooms[i].user_list_num; j++)
		{
			printf("name : %02s ", rooms[i].user_list[j].name);
			printf("index : %02d ", rooms[i].user_list[j].idx);
			printf("\n");
		}
		printf("\n\n");
	}
}

int RoomSearch(int key)
{
	int upper, lower, mid;

	lower = 0;
	upper = room_list_num-1;
	for(;;)
	{
		mid = (upper+lower)/2;

		if(rooms[mid].room_idx ==key)
			return mid;
		if(rooms[mid].room_idx > key)
			upper = mid-1;
		else
			lower = mid+1;

		if(upper<lower)
			return -1;
	}
}

char* UserNameSearch(int key, USER_INFO *user_list, int user_list_num)
{
	int upper, lower, mid;

	lower = 0;
	upper = user_list_num-1;
	for(;;)
	{
		mid = (upper+lower)/2;

		if(user_list[mid].idx == key)
			return user_list[mid].name;
		if(user_list[mid].idx > key)
			upper = mid-1;
		else
			lower = mid+1;

		if(upper<lower)
			return "이름을 못찾겠어ㅠㅠ";
	}
}

void Add_first(HISTORY *Target_List)
{
	ListNode *New = (ListNode*)malloc(sizeof(ListNode));
	New->msg.msg_idx = *((int*)(content_recv_buffer + msg_recv.content_size - sizeof(int)));
	New->msg.sender_idx = msg_recv.sender;
	New->msg.time = msg_recv.etc;
	New->msg.content = (char*)malloc(msg_recv.content_size - sizeof(int));
	memcpy(New->msg.content, content_recv_buffer, msg_recv.content_size - sizeof(int));
	New->msg.content[msg_recv.content_size - sizeof(int)] = '\0';

	if(Target_List->header->After == Target_List->tailer)
	{
		Target_List->header->After = New;
		Target_List->tailer->Before = New;
		New->After = Target_List->tailer;
		New->Before = Target_List->header;
		return;
	}

	New->Before = Target_List->header;
	New->After = Target_List->header->After;
	Target_List->header->After->Before = New;
	Target_List->header->After = New;


	return;
}
/*
void Add(HISTORY *Target_List, int Position)
{
	if(Position == 1)
	{
		Add_first(Target_List);
		return;
	}

	int pos = 1;
	ListNode *Cur = Target_List->header;
	ListNode *Temp = NULL;
	ListNode *New = (ListNode*)malloc(sizeof(ListNode));

	if(Position==2)
	{
		Temp = Cur;
		Cur = Cur->After;

		New->msg.msg_idx = *((int*)(content_recv_buffer + msg_recv.content_size - sizeof(int)));
		New->msg.sender_idx = msg_recv.sender;
		New->msg.time = msg_recv.etc;
		New->msg.content = (char*)malloc(msg_recv.content_size - sizeof(int));
		memcpy(New->msg.content, content_recv_buffer, msg_recv.content_size - sizeof(int));
		New->msg.content[msg_recv.content_size - sizeof(int)] = '\0';

		New->Before = Cur->Before;
		New->After = Temp->After;
		Temp->After = New;
		Temp->Before = Cur;
		return;
	}
	Cur = Cur->After;
	pos++;
	while(pos > Position-1)
	{
		Cur = Cur->After;
		pos++;
		if(pos = Position-2)
			Temp = Cur;
	}
	New->msg.msg_idx = *((int*)(content_recv_buffer + msg_recv.content_size - sizeof(int)));
	New->msg.sender_idx = msg_recv.sender;
	New->msg.time = msg_recv.etc;
	New->msg.content = (char*)malloc(msg_recv.content_size - sizeof(int));
	memcpy(New->msg.content, content_recv_buffer, msg_recv.content_size - sizeof(int));
	New->msg.content[msg_recv.content_size - sizeof(int)] = '\0';

	New->Before = Cur->Before;
	Cur->Before = New;
	New->After = Cur;
	Temp->After = Cur;
}*/

void Push_Back(HISTORY *Target_List)
{
	ListNode *New = (ListNode*)malloc(sizeof(ListNode));

	New->msg.msg_idx = *((int*)(content_recv_buffer + msg_recv.content_size - sizeof(int)));
	New->msg.sender_idx = msg_recv.sender;
	New->msg.time = msg_recv.etc;
	New->msg.content = (char*)malloc(msg_recv.content_size - sizeof(int));
	memcpy(New->msg.content, content_recv_buffer, msg_recv.content_size - sizeof(int));
	New->msg.content[msg_recv.content_size-sizeof(int)] = '\0';

	if (Target_List->header->After == Target_List->tailer)
	{
		Target_List->header->After = New;
		Target_List->tailer->Before = New;
		New->After = Target_List->tailer;
		New->Before = Target_List->header;
		return;
	}

	New->Before = Target_List->tailer->Before;
	New->After = Target_List->tailer;
	Target_List->tailer->Before->After = New;
	Target_List->tailer->Before = New;
}

void Delete(HISTORY *Target_List, int Position)
{
	int pos = 1;
	ListNode *Temp = NULL;
	ListNode *Cur = Target_List->header;
	while(pos<Position)
	{
		if(pos == Position-1)
			Temp = Cur;
		Cur = Cur->After;
		pos++;
	}
	Cur->After->Before = Cur->Before;
	Cur->Before->After = Cur->After;
	free(Cur);
}

void HistoryInit(HISTORY *Target_List)
{
	Target_List->header = (ListNode*)malloc(sizeof(ListNode));
	Target_List->tailer = (ListNode*)malloc(sizeof(ListNode));

	Target_List->header->After = Target_List->tailer;
	Target_List->header->Before = NULL;
	Target_List->tailer->Before = Target_List->header;
	Target_List->tailer->After = NULL;
}

void Replace(HISTORY *Target_List, int Position)
{
	int pos =1;
	ListNode *Cur = Target_List->header;
	while(pos<Position)
	{
		Cur = Cur->After;
		pos++;
	}

	Cur->msg.msg_idx = *((int*)(content_recv_buffer + msg_recv.content_size - sizeof(int)));
	Cur->msg.sender_idx = msg_recv.sender;
	Cur->msg.time = msg_recv.etc;
	Cur->msg.content = (char*)malloc(msg_recv.content_size - sizeof(int));
	memcpy(Cur->msg.content, content_recv_buffer, msg_recv.content_size - sizeof(int));
	Cur->msg.content[msg_recv.content_size - sizeof(int)] = '\0';
}

int Find(HISTORY *Target_List, int key)
{
	int pos;

	ListNode *Cur = Target_List->header;
	int i = 1;
	if(Cur->msg.msg_idx == key)
		pos = i;
	i++;

	Cur = Cur->After;
	while(Cur !=Target_List->header)
	{
		if(Cur->msg.msg_idx == key)
			pos = i;
		i++;
		Cur = Cur->After;
	}

	return pos;
}

int Find_R(HISTORY *Target_List, int key)
{
	int pos;

	ListNode *Cur = Target_List->tailer;
	int i = 1;
	if(Cur->msg.msg_idx == key)
		pos = i;
	i++;

	Cur = Cur->Before;
	while(Cur !=Target_List->header)
	{
		if(Cur->msg.msg_idx == key)
			pos = i;
		i++;
		Cur = Cur->Before;
	}

	return pos;
}


int get_length(HISTORY *Target_List)
{
	ListNode *Cur = Target_List->header;
	int i =1;
	i++;
	Cur = Cur->After;
	while(Cur != Target_List->header)
	{
		i++;
		Cur = Cur->After;
	}

	return i;
}

void is_empty(HISTORY *Target_List)
{
	if (Target_List->header == NULL)
	{
		printf("리스트가 비었습니다.");
	}
	if (Target_List->header != NULL)
	{
		printf("리스트에 내용이 잇습니다.");
	}
}

void Printing(HISTORY *Target_List)
{
	if (Target_List->header->After == Target_List->tailer)
	{
		printf("메세지가 없음");
		return;
	}

	ListNode *Cur = Target_List->tailer->Before;

	while (Cur != Target_List->header)
	{
		printf("%s", Cur->msg.content);
		Cur = Cur->Before;
	}
	printf("\n");
}


