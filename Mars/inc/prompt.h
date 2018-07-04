#ifndef _PROMPT_H_
#define _PROMPT_H_

#include <stdio.h>
#include <stdlib.h>
#include "define.h"
#include "message_handler.h"


int main_prompt();
int sigin_prompt();
int room_create_prompt();
int friend_add_prompt();
int room_enter_prompt();

int sigin_prompt()
{
    char id[33];
    char password[33];
    char name[33];
    char buffer[97];

    printf("id : ");
    scanf("%s",id);
    printf("password : ");
    scanf("%s",password);
    printf("name: ");
    scanf("%s",name);

    memcpy(buffer,id,32);
    memcpy(buffer+32,password,32);
    memcpy(buffer+64,name,32);
    sendMessage(2,-1,my_sock_info,-1,buffer);

    return 1;
}

int main_prompt()
{
    int option;
    while(1)
    {
        printf("1. Create Room\n2. Enter Room\n3. Add Friend\n4. LogOut\n");
        scanf("%d",&option);
        if(option==1)
        {
            room_create_prompt();
        }
	else if(option==2)
	{

	}
	else if(option==3)
	{

	}
	else if(option==4)
        {
            return 0;
        }
	else
	{
	    printf("ssibal plz insert RIGHT value");
	}
    }
}

int room_create_prompt()
{
    bool* toggle = (bool*)malloc(friend_list_num);
    int* content = (int*)malloc(friend_list_num);

    int option;
    int toggle_count=0;
    int j=0;

    for(int i=0;i<friend_list_num;i++)
    {
        toggle[i]=false;
    }

    while(1)
    {
        fflush(stdin);
        printf("Add Friend : ");
        scanf("%d",&option);

        if(option>friend_list_num+1 || option<1)
        {
            printf("error option.\n");
            return -1;
        }
        else if(option==friend_list_num+1)
            break;

        if(toggle[option-1]==false)
        {
            toggle[option-1]=true;
            toggle_count++;
        }
        else
        {
            toggle[option-1]=false;
            toggle_count--;
        }
    }

    for(int i=0; i<friend_list_num;i++)
    {
        if(toggle[i]==true)
        {
            memcpy(content+j,&(friend_list[i].idx),4);
            j++;
        }
    }

    sendMessage(1,my_index,toggle_count,-1,(char*)content);
    free(toggle);
    sem_wait(&sem_temp);
    return 0;
}

int room_enter_prompt()
{
    int option;
    scanf("%d",&option);
    sendMessage(6,my_index,0,rooms[option].room_idx,NULL);

    return 0;
}

int chat_prompt()
{
    char chat_buffer[4096];
    while(strcmp(chat_buffer,"qq")!=0)
    {
    	scanf("%[^\n]s",chat_buffer);
    			if(strcmp(chat_buffer,"qqq")==0)
    				break;
    			else if(strcmp(chat_buffer,"history")==0)
    				sendMessage(6,my_index,0,current_room,NULL);
    			else if(strlen(chat_buffer)>0)
    				sendMessage(0,my_index,3,current_room,chat_buffer);
    			memset(chat_buffer,0,4096);
    			fflush(stdin);
    }

    return 0;
}




#endif /* prompt_h */
