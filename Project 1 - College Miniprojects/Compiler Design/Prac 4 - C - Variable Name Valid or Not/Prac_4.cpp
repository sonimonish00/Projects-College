#include<iostream>
#include <string>

using namespace std;
int main()
{
	string stmt;
	int flag=0;
	cout<<"Enter your variable name :- ";
	getline(std::cin, stmt);
	for(int i=0;i<stmt.length();i++)
	{
		if(stmt[i]=='+'||stmt[i]=='-'||stmt[i]=='/'||stmt[i]=='*'||stmt[i]=='%'||stmt[i]=='^')
		{
			if(stmt[i-1]=='+'||stmt[i-1]=='-'||stmt[i-1]=='/'||stmt[i-1]=='*'||stmt[i-1]=='%'||stmt[i-1]=='^')
			{
				flag=1;
			}
			if(stmt[i+1]=='+'||stmt[i+1]=='-'||stmt[i+1]=='/'||stmt[i+1]=='*'||stmt[i+1]=='%'||stmt[i+1]=='^')
			{
				flag=1;
			}			
		}
	}
	if(flag==0)
	{
		cout<<"valid..";
	}
	else
	{
		cout<<"not valid";
	}
	return 0;
}
