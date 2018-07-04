#ifndef _DATASTRUCTURE_H_
#define _DATASTRUCTURE_H_
#include "structs.h"
#include "define.h"
typedef struct MESSAGE_QUEUE{
	MESSAGE_QUEUE_ELEMENT* head;
	MESSAGE_QUEUE_ELEMENT* tail;
}MESSAGE_QUEUE;

typedef struct MESSAGE_QUEUE_ELEMENT{
	MESSAGE msg;
	MESSAGE_QUEUE_ELEMENT* next;
}MESSAGE_QUEUE_ELEMENT;


MESSAGE_QUEUE_ELEMENT message_pop(MESSAGE_QUEUE msg_queue)
{

}

void message_push(MESSAGE_QUEUE msg_queue)
{

}
#endif