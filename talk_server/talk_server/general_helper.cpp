#include "general_helper.h"
#include "define.h"

ROOM* findRoom(int room_idx)
{
	room_iter=room.find(room_idx);
	if(room_iter!=room.end())
		return room_iter->second;
	else
		return NULL;
}

SOCKET findSocket(int user_idx)
{
	sock_iter=sock.find(user_idx);
	if(sock_iter!=sock.end())
		return sock_iter->second;
	else
		return NULL;
}

bool my_con(MYSQL** conn, MYSQL* conn_temp)
{
	mysql_init(conn_temp);
	*conn=mysql_real_connect(conn_temp, DB_HOST, DB_USER, DB_PASS, DB_NAME, 3306, (char*)NULL, 0);
	if(conn==NULL)
	{
		return false;
	}
	else
		return true;
}


int createRoom()
{
	int i=room.size();
	for(;;i++)
	{
		room_iter=room.find(i);
		if(room_iter==room.end())
			break;
	}

	room.insert(pair<int,ROOM*>(i,new ROOM()));
	return i;
}

void createRoom(int room_idx)
{
	room.insert(pair<int,ROOM*>(room_idx,new ROOM()));
}

int addUser(int room_idx, int user_idx) //room_idx 번 방에 user_idx번 유저를 포함시킴
{
	room_iter=room.find(room_idx);
	if(room_iter==room.end())
	{
		printf("존재하지 않는 방 번호가 addUser로 전달됨");
		return -1;
	}
	room_iter->second->user.push_back(user_idx);

	MYSQL *connection=NULL,conn;
	int query_stat;

	char sql[500];

	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"insert into room values(%d, %d)",room_idx, user_idx);
	query_stat=mysql_query(connection, sql);
	mysql_close(connection);
	return query_stat;
}

int loginCheck(char* id, char* pw, SOCKET clnt_sock)
{
	MYSQL *connection=NULL, conn;

	MYSQL_RES *sql_result;
	MYSQL_ROW sql_row;
	int query_stat;
	int ret_val;
	char sql[500];

	if(!my_con(&connection,&conn))
	{
		printf("db connection error while loginCheck()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select * from user where id='%s' and password='%s'",id,pw);
	query_stat=mysql_query(connection, sql);
	sql_result=mysql_store_result(connection);
	if((sql_row=mysql_fetch_row(sql_result)) !=NULL)
	{
		sock_iter=sock.find(atoi(sql_row[0]));
		if(sock_iter!=sock.end())
		{
			sock.erase(atoi(sql_row[0]));
		}
		sock.insert(pair<int,SOCKET>(atoi(sql_row[0]),clnt_sock));
		ret_val=atoi(sql_row[0]);
		mysql_free_result(sql_result);
		mysql_close(connection);
		return ret_val;
	}
	mysql_free_result(sql_result);
	mysql_close(connection);
	return -1;
}

int regUser(char* id, char* pw, char* name, char *email,char *phone)
{
	
	MYSQL *connection=NULL,conn;
	int query_stat;

	char sql[500];
	char authkey[33]={0,};
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	generateAuthkey(authkey);
	sprintf(sql,"insert into user(id, password, name,auth_key,reg_auth,pw_auth,email,phone,reg_date) values('%s','%s','%s','%s',0,0,'%s','%s',now())",id,pw,name,authkey,email,phone);
	query_stat=mysql_query(connection, sql);
	mysql_close(connection);
	return query_stat;  ///////////////일단 그냥 query_stat 리턴하는걸로 했음. 나중에 수정해야할지도?
}

int getUserName(int user_idx, char* buffer)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result;
	MYSQL_ROW sql_row;
	char sql[500];

	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select name from user where idx=%d",user_idx);
	query_stat=mysql_query(connection, sql);
	sql_result=mysql_store_result(connection);
	if((sql_row=mysql_fetch_row(sql_result)) !=NULL)
	{
		memcpy(buffer,sql_row[0],32);
		mysql_free_result(sql_result);
		mysql_close(connection);
		return 0;
	}
	mysql_free_result(sql_result);
	mysql_close(connection);
	return -1;
}

int getUserIdx(char* id)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result;
	MYSQL_ROW sql_row;
	char sql[500];
	int ret_val;

	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select idx from user where id='%s'",id);
	query_stat=mysql_query(connection, sql);
	sql_result=mysql_store_result(connection);

	if((sql_row=mysql_fetch_row(sql_result)) !=NULL)
	{
		ret_val=atoi(sql_row[0]);
		mysql_free_result(sql_result);
		mysql_close(connection);
		return ret_val;
	}
	mysql_free_result(sql_result);
	mysql_close(connection);
	return -1;
}


int getFriendList(int user_idx, char* buffer)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result_idx;
	MYSQL_RES *sql_result_name;
	MYSQL_ROW sql_row_idx;
	MYSQL_ROW sql_row_name;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select friend_idx from friend where my_idx=%d",user_idx);
	query_stat=mysql_query(connection, sql);
	sql_result_idx=mysql_store_result(connection);
	
	while((sql_row_idx=mysql_fetch_row(sql_result_idx)) !=NULL)
	{
		sprintf(sql,"select name from user where idx=%d",atoi(sql_row_idx[0]));
		query_stat=mysql_query(connection, sql);
		sql_result_name=mysql_store_result(connection);
		*((int*)(buffer+(i*36)))=atoi(sql_row_idx[0]);
		sql_row_name=mysql_fetch_row(sql_result_name);
		memcpy(buffer+4+(i*36),sql_row_name[0],32);
		mysql_free_result(sql_result_name);
		i++;
	}

	mysql_free_result(sql_result_idx);
	mysql_close(connection);
	return i;
}

int getFriendCount(int user_idx)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result_idx;
	MYSQL_RES *sql_result_name;
	MYSQL_ROW sql_row;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select count(*) from friend where my_idx=%d",user_idx);
	query_stat=mysql_query(connection, sql);
	sql_result_idx=mysql_store_result(connection);
	
	sql_row=mysql_fetch_row(sql_result_idx);
	i=atoi(sql_row[0]);
	mysql_free_result(sql_result_idx);
	mysql_close(connection);
	return i;
}

int getRoomCount(int user_idx)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result_idx;
	MYSQL_RES *sql_result_name;
	MYSQL_ROW sql_row;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select count(*) from room where user_idx=%d",user_idx);
	query_stat=mysql_query(connection, sql);
	sql_result_idx=mysql_store_result(connection);
	
	sql_row=mysql_fetch_row(sql_result_idx);
	i=atoi(sql_row[0]);
	mysql_free_result(sql_result_idx);
	mysql_close(connection);
	return i;
}

int storeMessage(int msg_idx, int room_idx, int sender, char* content,time_t timestamp)
{
	MYSQL *connection=NULL,conn;
	int query_stat;

	char sql[500];

	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"insert into talk_history values(%d,%d,%d,'%s',%d)",msg_idx,room_idx,sender,content,timestamp);
	query_stat=mysql_query(connection, sql);
	mysql_close(connection);
	return query_stat;
}

int addFriend(int my_idx, int friend_idx)
{
	MYSQL *connection=NULL,conn;
	int query_stat;

	char sql[500];

	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"insert into friend values(%d,%d)",my_idx,friend_idx);
	query_stat=mysql_query(connection, sql);
	mysql_close(connection);
	return query_stat;
}

int getNextMsgIdx(int room_idx)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result_idx;
	MYSQL_RES *sql_result_name;
	MYSQL_ROW sql_row;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select * from talk_history where room_idx=%d order by msg_idx desc limit 1",room_idx);
	query_stat=mysql_query(connection, sql);
	sql_result_idx=mysql_store_result(connection);
	
	sql_row=mysql_fetch_row(sql_result_idx);

	if(sql_row==NULL)
		i=-1;
	else
		i=atoi(sql_row[0]);

	mysql_free_result(sql_result_idx);
	mysql_close(connection);
	return i+1;
}

int getRoomList(int user_idx, int* output)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result_idx;
	MYSQL_ROW sql_row;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select distinct room_idx from room where user_idx=%d",user_idx);
	query_stat=mysql_query(connection, sql);
	sql_result_idx=mysql_store_result(connection);
	
	while((sql_row=mysql_fetch_row(sql_result_idx)) !=NULL)
	{
		output[i]=atoi(sql_row[0]);
		i++;
	}
	mysql_free_result(sql_result_idx);
	mysql_close(connection);
	return i;
}

int getUserList(int room_idx,char* output)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result_idx;
	MYSQL_RES *sql_result_name;
	MYSQL_ROW sql_row;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select user_idx from room where room_idx=%d",room_idx);
	query_stat=mysql_query(connection, sql);
	sql_result_idx=mysql_store_result(connection);
	while((sql_row=mysql_fetch_row(sql_result_idx)) !=NULL)
	{
		*((int*)(output+(36*i)))=atoi(sql_row[0]);
		getUserName(atoi(sql_row[0]),output+4+(36*i));
		i++;
	}
	mysql_free_result(sql_result_idx);
	mysql_close(connection);
	return i;
}

int loadRoomList()
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result_idx;
	MYSQL_RES *sql_result_user;
	MYSQL_ROW sql_row;
	MYSQL_ROW sql_row_user;
	map<int, ROOM*>::iterator room_iter;
	char sql[500];
	int room_idx;
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select distinct room_idx from room");
	query_stat=mysql_query(connection, sql);
	sql_result_idx=mysql_store_result(connection);
	while((sql_row=mysql_fetch_row(sql_result_idx)) !=NULL)
	{
		room_idx=atoi(sql_row[0]);
		createRoom(room_idx);
		sprintf(sql,"select user_idx from room where room_idx=%d",room_idx);
		query_stat=mysql_query(connection,sql);
		sql_result_user=mysql_store_result(connection);
		while((sql_row=mysql_fetch_row(sql_result_user)) !=NULL)
		{
			room_iter=room.find(room_idx);
			room_iter->second->user.push_back(atoi(sql_row[0]));
		}
		mysql_free_result(sql_result_user);
	}
	mysql_free_result(sql_result_idx);
	mysql_close(connection);
	return i;
}

void generateAuthkey(char* str)
{
	char table[]={'1','2','3','4','5','6','7','8','9','0',
		'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p',
		'q','r','s','t','u','v','w','x','y','z',
		'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P',
		'Q','R','S','T','U','V','W','X','Y','Z'};
	srand(time(NULL));
	
	for(int i=0;i<32;i++)
	{
		int val=rand()%62;
		str[i]=table[val];
	}
}

bool isAuthed(int user_idx, int etc)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result;
	MYSQL_ROW sql_row;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	if(etc==0)
		sprintf(sql,"select reg_auth from user where idx=%d",user_idx);
	else if(etc==1)
		sprintf(sql,"select pw_auth from user where idx=%d",user_idx);

	query_stat=mysql_query(connection, sql);
	sql_result=mysql_store_result(connection);
	if(sql_row=mysql_fetch_row(sql_result))
	{
		if(atoi(sql_row[0])==1)
		{
			mysql_free_result(sql_result);
			mysql_close(connection);
			return true;
		}
	}
	
	mysql_free_result(sql_result);
	mysql_close(connection);
	return false;
}

int authenticate(int user_idx, int etc, char* auth_key)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result;
	MYSQL_ROW sql_row;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"select auth_key from user where idx=%d",user_idx);
	query_stat=mysql_query(connection, sql);
	sql_result=mysql_store_result(connection);
	sql_row=mysql_fetch_row(sql_result);
	
	if(strcmp(auth_key,sql_row[0])==0)
	{
		if(etc==0)
		{
			sprintf(sql,"update user set reg_auth=1 where idx=%d",user_idx);
		}
		else if(etc==1)
		{
			sprintf(sql,"update user set pw_auth=1 where idx=%d",user_idx);
		}
		query_stat=mysql_query(connection, sql);
		mysql_free_result(sql_result);
		mysql_close(connection);
		return 0;

	}
	mysql_free_result(sql_result);
	mysql_close(connection);
	return -1;
}

int resetPassword(int user_idx, char* pass)
{
	MYSQL *connection=NULL,conn;
	int query_stat;
	MYSQL_RES *sql_result;
	MYSQL_ROW sql_row;
	char sql[500];
	int i=0;
	if(!my_con(&connection,&conn))
	{
		printf("db connection error while regUser()");
	}
	mysql_query(connection,"set names euckr");
	sprintf(sql,"update user set password='%s' where idx=%d",pass,user_idx);
	query_stat=mysql_query(connection, sql);

	sprintf(sql,"update user set pw_auth=0 where idx=%d",user_idx);
	query_stat=mysql_query(connection, sql);


	mysql_close(connection);

	return query_stat;
}
