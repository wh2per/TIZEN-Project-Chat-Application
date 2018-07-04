#ifndef _MESSAGE_QUEUE_H_
#define _MESSAGE_QUEUE_H_

#include <stdio.h>
#include "Message.h"
#include "Message_Queue_Element.h"

class MESSAGE_QUEUE{

public:
	MESSAGE_QUEUE_ELEMENT* head;
	MESSAGE_QUEUE_ELEMENT* tail;
	int count;

	MESSAGE msg_pop()
	{
		if(count>0)
		{
			count--;
			MESSAGE temp;
			MESSAGE_QUEUE_ELEMENT* pop_next=head->next;
			memcpy(&temp, &(head->msg),sizeof(MESSAGE));
			delete(head);
			head=pop_next;
			return temp;
		}
		else
		{
			printf("pop() error");
		}
	}

	void msg_push(MESSAGE* msg)
	{
		if(count==0)
		{
			head=new MESSAGE_QUEUE_ELEMENT(msg);
			tail=head;
		}
		else
		{
			tail->next=new MESSAGE_QUEUE_ELEMENT(msg);
			tail=tail->next;
		}
		count++;
	}
};

#endif