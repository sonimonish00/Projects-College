%{
#include<stdio.h>
int lines=0;
%}

%% 
\n {lines++;}
%%

int main()
{
yyin= fopen("monish.txt","r");
yyout=fopen("soni.txt","w");
yylex();
printf(" This File contains ...");
printf("\n\t%d lines", lines);
return 0;
}
 
int yywrap()
{
return(1);
}
