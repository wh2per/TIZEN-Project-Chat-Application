#ifndef _DEFINE_H_
#define _DEFINE_H_

#include <semaphore.h>

#include "structs.h"

#define HEADERSIZE 20
#define MSG_TALK 0
#define MSG_ROOMCREATE 1
#define MSG_USERREGISTER 2
#define MSG_LOGIN 3
#define MSG_FRIENDINFO 4
#define MSG_FRIENDADD 5
#define MSG_HISTORY 6
#define MSG_ROOMEXIT 7
#define MSG_ROOMUSERADD 8
#define MSG_IDSEARCH 9
#define MSG_PWSEARCH 10
#define MSG_IDDUPLICATE 11
#define MSG_PWRESET 12
#define MSG_AUTHREQUEST 13
#define MSG_AUTHCHECK 14


extern MESSAGE msg_send;
extern MESSAGE msg_recv;

extern HISTORY chat_memory;
extern int chat_pos;

extern char* content_send_buffer;
extern char* content_recv_buffer;
extern int sock;

extern int my_index;
extern int current_room;
extern int my_sock_info;

extern int room_list_size;
extern int room_list_num;
extern ROOM *rooms;

extern int friend_list_size;
extern int friend_list_num;
extern USER_INFO *friend_list;

extern sem_t sem_login;
extern sem_t sem_friend_list;
extern sem_t sem_room_list;
extern sem_t sem_load_message;


extern char my_id[32];
extern int flag;

#endif
