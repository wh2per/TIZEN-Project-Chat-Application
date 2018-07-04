#include "define.h"

#include "general_helper.h"
#include "message_helper.h"

#pragma comment(lib, "Ws2_32.lib")

int main(int argc, char **argv)
{
	WSADATA wsaData;
	SOCKET servSock;
	SOCKET clntSock;
	SOCKADDR_IN servAddr;
	SOCKADDR_IN clntAddr;
	int clntAddrSize;
	HANDLE hThread;
	DWORD dwThreadID;
	WSAStartup(MAKEWORD(2,2), &wsaData);
	servSock=socket(PF_INET, SOCK_STREAM, 0);
	memset(&servAddr, 0, sizeof(servAddr));
	servAddr.sin_family=AF_INET;
	servAddr.sin_addr.s_addr=htonl(INADDR_ANY);
	servAddr.sin_port=htons(19564);
	bind(servSock, (SOCKADDR*) &servAddr, sizeof(servAddr));
	listen(servSock, 5);
	FD_ZERO(&reads);
	FD_SET(servSock,&reads);
	loadRoomList();
	while(1)
	{
		temps=reads;
		if(select(0,&temps,0,0,NULL)==-1)
		{
			printf("select() error\n");  //접속을 끊을시에 FD_SET을 수정해줄 방법을 생각해보자
		}
		else
		{

			for(int i=0;i<temps.fd_count;i++)
			{
				if(temps.fd_array[i]==servSock)
				{
					clntAddrSize=sizeof(clntAddr);
					clntSock=accept(servSock, (SOCKADDR*)&clntAddr, &clntAddrSize);
					send(clntSock,(char*)(&clntSock),4,0);
					FD_SET(clntSock,&reads);
				}
				else
				{
					if(recvMessage(temps.fd_array[i])!=-1)
						msg_recv.handleMessage();
					else
					{
						FD_CLR(temps.fd_array[i],&reads);
						//여기에 연결이 종료되었을때 해야하는 동작을 넣자
					}
				}
			}
		}
	}
	WSACleanup();
	return 0;
}
//clntAddrSize=sizeof(clntAddr);
//clntSock=accept(servSock, (SOCKADDR*)&clntAddr, &clntAddrSize);
//hThread=(HANDLE)_beginthreadex(NULL,0,ClientConn,(void*)clntSock, 0, (unsigned*)&dwThreadID);