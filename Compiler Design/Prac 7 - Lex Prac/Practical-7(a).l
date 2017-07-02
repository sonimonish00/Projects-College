%{
#include<stdio.h>
int num=0;
%}
%%
[0-9] {printf("%s\n",yytext);}
%%
int yywrap()
{
return(1);
}
int main(void)
{
yyin= fopen("Untitled Document","r");
yylex();
return 0;
}
