%{
#include<stdio.h>
int num=0;
%}
%%
"<"[^>]*> { printf("VALUE: %s\n", yytext); }
%%
int yywrap()
{
return(1);
}
int main(void)
{
yyin= fopen("Untitled Document1","r");
yylex();
return 0;
}
