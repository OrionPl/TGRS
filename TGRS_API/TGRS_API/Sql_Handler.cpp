#include "stdafx.h"
#include "Sql_Handler.h"
#include "mysqlx/xdevapi.h"
#include <iostream>

using namespace mysqlx;

Sql_Handler::Sql_Handler()
{
}


Sql_Handler::~Sql_Handler()
{
}

extern "C" _declspec(dllexport)
std::string SqlQuery(std::string ip, int port, std::string user, std::string password, std::string dbName, std::string tableName, std::string select, std::string whereA, std::string orderBy)
{
	Session sess(ip, port, user, password);
	Schema db = sess.getSchema(dbName);



	// or Schema db(sess, "test");

	//Collection myColl = db.getCollection("my_collection");
	// or Collection myColl(db, "my_collection");

	//DocResult myDocs = myColl.find("name like :param")
		//.limit(1)
		//.bind("param", "S%").execute();

	//std::cout << myDocs.fetchOne();


	Table table = db.getTable(tableName);

	RowResult res = table.select(select)
		.where(whereA)
		.orderBy(orderBy)
		.execute();

	std::string ret = res.fetchAll();

	return ret;
}
