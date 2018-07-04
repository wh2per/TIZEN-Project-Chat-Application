#ifndef _MESSAGE_HANDLER_H_
#define _MESSAGE_HANDLER_H_



int setBuffer(int type, int sender, int etc, int room_idx, char* content);
void setMessage(int type, int sender, int etc, int room_idx, char* content);
void sendMessage(int type, int sender, int etc, int room_idx, char* content);
void recvMessage();
void handleMessage();




#endif /* message_handler_h */
