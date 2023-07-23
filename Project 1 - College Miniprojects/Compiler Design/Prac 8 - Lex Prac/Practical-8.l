%{
#include<stdio.h>
int count=0,flag=0,m=0;
%}
%%
((\/)(\/).*"\n") {count++;}
("/*")(.*|("\n")*) {flag=1;}
"*/" {if(flag==1){count++;flag=0;}}
%%
int yywrap()
{
return 1;
}
int main()
{
yyin=fopen("test.c","r");
yyout=fopen("write.c","w");
yylex();
printf("no of comments=%d \n\n",count+2);
return 0;
}
