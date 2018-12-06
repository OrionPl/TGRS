#include "pch.h"
#include <iostream>
#include <string>
#include <Windows.h>
#include <sqlext.h>
#include <sqltypes.h>
#include <sql.h>


using namespace std;

int main()
{
	while (true)
	{
		string choice;
		getline(cin, choice);
		

		if (choice == "check for connectivity")
		{
			cout << "";
		}
		else if (choice == "exit")
		{
			exit(0);
		}
	}
}

void showSQLError(unsigned int handleType, const SQLHANDLE& handle)
{
	SQLCHAR SQLState[1024];
	SQLCHAR message[1024];
	if (SQL_SUCCESS == SQLGetDiagRec(handleType, handle, 1, SQLState, NULL, message, 1024, NULL))
	{
		cout << "SQL Runtime Error: \n" << message << "\n With SQLState:: \n" << SQLState;
	}
}