#include<iostream>
#include <string>

using namespace std;
int main()
{
	string stmt;
	int flag=0;
	cout<<"Enter your statement :- ";
	getline(std::cin, stmt);
	if(stmt[0]=='/' && stmt[1]=='/')
	{
		cout<<"This Statement is comment..";
		flag=1;
	}
	if(stmt[0]=='/' && stmt[1]=='*')
	{		
		if(stmt[stmt.length()-2]=='*' && stmt[stmt.length()-1]=='/')
		{
			cout<<"This Statement is comment..";	
			flag=1;
		}
	}
	if(flag==0)
	{
		cout<<"This statement is not a comment..";
	}
	return 0;
}
