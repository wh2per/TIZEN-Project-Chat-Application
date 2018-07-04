#ifndef _GENERAL_HELPER_H_
#define _GENERAL_HELPER_H_

#include <WinSock2.h>
#include "Room.h"
#include <mysql.h>

ROOM* findRoom(int room_idx);

SOCKET findSocket(int user_idx);

bool my_con(MYSQL** conn, MYSQL* conn_temp);

int createRoom();

void createRoom(int room_idx);

int addUser(int room_idx, int user_idx); //room_idx 번 방에 user_idx번 유저를 포함시킴

int loginCheck(char* id, char* pw, SOCKET clnt_sock);

int regUser(char* id, char* pw, char* name, char *email,char *phone);

int getUserName(int user_idx, char* buffer);

int getUserIdx(char* id);

int getFriendList(int user_idx, char* buffer);

int getFriendCount(int user_idx);

int getRoomCount(int user_idx);

int storeMessage(int msg_idx, int room_idx, int sender, char* content,time_t timestamp);

int addFriend(int my_idx, int friend_idx);

int getNextMsgIdx(int room_idx);

int getRoomList(int user_idx, int* output);

int getUserList(int room_idx,char* output);

int loadRoomList();

void generateAuthkey(char* str);

bool isAuthed(int user_idx, int etc);

int authenticate(int user_idx, int etc, char* auth_key);

int resetPassword(int user_idx, char* pass);

#endif