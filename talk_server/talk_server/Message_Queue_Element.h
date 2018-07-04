#ifndef _MESSAGE_QUEUE_ELELMENT_H_
#define _MESSAGE_QUEUE_ELELMENT_H_

#include <stdio.h>
#include "Message.h"


class MESSAGE_QUEUE_ELEMENT
{

public:
	MESSAGE msg;
	MESSAGE_QUEUE_ELEMENT* next;

	MESSAGE_QUEUE_ELEMENT(MESSAGE* msg)
	{
		memcpy(&(this->msg),msg,sizeof(MESSAGE));
	}
};

#endif
