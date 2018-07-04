#include <string.h>
#include "define.h"



MESSAGE msg_send;
MESSAGE msg_recv;

HISTORY chat_memory;

char* content_send_buffer;
char* content_recv_buffer;
int sock;

int chat_pos=1;

int my_index=-1;
int current_room=-1;
int my_sock_info=-1;

int room_list_size;
int room_list_num=0;
ROOM *rooms;

int friend_list_size;
int friend_list_num=0;
USER_INFO *friend_list;

sem_t sem_login;
sem_t sem_friend_list;
sem_t sem_room_list;
sem_t sem_load_message;

char my_id[32]={0,};
int flag=-1;
