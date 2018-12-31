#pragma once
#include <string>

using namespace std;

class Sql_Handler
{
public:
	Sql_Handler();
	~Sql_Handler();
	void* Sql_handlernew();
	std::string SqlQuery(std::string ip, int port, std::string user, std::string password, std::string dbName, std::string tableName, std::string select, std::string whereA, std::string orderBy);
};

