#ifndef _MESSAGE_HELPER_H_
#define _MESSAGE_HELPER_H_
#include <WinSock2.h>

int recvMessage(SOCKET sock);
void sendSockMessage(SOCKET sock, int type, int sender, int etc, int room_idx, char* content, int content_size);
void sendUserMessage(int user_idx, int type, int sender, int etc, int room_idx, char* content, int content_size);
void sendRoomMessage(int send_room_idx, int type, int sender, int etc, int room_idx, char* content, int content_size);
int handleHistoryRequest(int room_idx, int etc, int sender);



#endif