#pragma once
#include <string>

class Login_Handler
{
public:
	Login_Handler();
	~Login_Handler();
	std::string username;
	std::string password;
	bool CheckForLogin(std::string username, std::string password);
};

