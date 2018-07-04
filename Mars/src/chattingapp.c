#include "app_main.h"
#include <tizen.h>


#include <sys/socket.h>
#include <semaphore.h>
#include <pthread.h>
#include <unistd.h>
#include <sys/types.h>
#include <arpa/inet.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "define.h"
#include "message_handler.h"


void *recvLoop(void *arg)
{
    while(1)
    {
        recvMessage();
        handleMessage();
    }
}

int main(int argc, char **argv)
{

	 pthread_t t_id;
	 struct sockaddr_in serv_addr;

	 sem_init(&sem_login,0,0);
	 sem_init(&sem_friend_list,0,0);
	 sem_init(&sem_room_list,0,0);
	 sem_init(&sem_load_message,0,0);

	 sock = socket(PF_INET,SOCK_STREAM,0);
	 memset(&serv_addr,0,sizeof(serv_addr));
     serv_addr.sin_family=AF_INET;
     serv_addr.sin_addr.s_addr=inet_addr("192.168.56.1");
     serv_addr.sin_port=htons(19564);

     if(connect(sock,(struct sockaddr*)&serv_addr,sizeof(serv_addr))==-1)
     {

	     return 0;
     }
     pthread_create(&t_id,NULL,recvLoop,(void*)sock);
	 read(sock,(char*)(&my_sock_info),4);


     int result = 0;
     app_data *app = app_create();
     if (app)
     	{
     		result = app_run(app, argc, argv);
     		app_destroy(app);
     	}

     //close(sock);
     return result;
}
