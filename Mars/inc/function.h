#ifndef _FUNCTION_H_
#define _FUNCTION_H_

#include "structs.h"

void InitRoomArray(int asize);
void InitFriendArray(int asize);
void InitRoomUserArray(int aszie, int room_idx);

void InsertRoom(int idx);
void InsertFriend(int idx, int i);
void InsertRoomUser(int idx, int room_idx);

void DeleteRoom(int idx);
void DeleteFriend(int idx);
void DeleteRoomUser(int idx, int room_idx);

void AppendRoom();
void AppendFriend(int count);
void AppendRoomUser(int room_idx);

void UnInitRoomArray();
void UnInitFriendArray();
void UnInitRoomUser(int room_idx);

void DumpRoomArray(char *sMark);
void DumpFriendArray(char *sMark);
void DumpRoomUserArray(char *sMark, int room_idx);

int RoomSearch(int key);
char* UserNameSearch(int key, USER_INFO *user_list, int user_list_num);

void Add_first(HISTORY *Target_List);
void Push_Back(HISTORY *Target_List);
void Delete(HISTORY *Target_List, int Position);
void HistoryInit(HISTORY *Target_List);
void Replace(HISTORY *Target_List, int Position);
int Find(HISTORY *Target_List, int key);
int Find_R(HISTORY *Target_List, int key);
int get_length(HISTORY *Target_List);
void is_empty(HISTORY *Target_List);
void Printing(HISTORY *Target_List);


#endif
