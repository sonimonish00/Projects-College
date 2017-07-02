#include<iostream>
#include <string>

using namespace std;
int main()
{
	string stmt;
	int flag=0;
	cout<<"Enter your variable name :- ";
	getline(std::cin, stmt);
	if(isdigit(stmt[0]))
	{
		flag=1;
	}
	if(flag==0)
	{
		for(int i=0;i<stmt.length();i++)
		{
			if(stmt[i]=='_' ||isalpha(stmt[i])||isdigit(stmt[i]))
			{
				
			}
			else
			{
				flag=1;
			}
		}
	}
	if(flag==1)
	{
		cout<<"Variable Not valid..";
	}
	else
	{
		cout<<"Variable is valid..";
	}
	return 0;
}
