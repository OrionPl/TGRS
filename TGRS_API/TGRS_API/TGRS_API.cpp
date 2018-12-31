// TGRS_API.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <windows.h>
#include <string>
#include"Sql_Handler.h"


class nuda
{
public:
	Sql_Handler* pointer;
	nuda()
	{
		pointer=new Sql_Handler();
	}
};
int main()
{
	nuda jej;
	jej.pointer->SqlQuery("localhost", 1, "random", "somerandompassword", "users", "users", "*", "username=orion", "name");
}