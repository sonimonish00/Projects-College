#include<stdio.h>
#include<string.h>
int main()
{
char str[100];
int i,key;

printf("\nEnter Plain Text:");
scanf("%s",str);
key=(int)time(NULL)%5;

printf("The Key is:");
printf("\n%d",key);

if(key==0)
key+=1;

encrypt(str,key);
printf("\n%s",str);

decrypt(str,key);
printf("\n%s\n",str);

return 0;
}
void encrypt(char *ch,int key)
{
	while(*ch!='\0')
	{
		*ch += key;
		ch++;
	}	
}
void decrypt(char *ch,int key)
{
	while(*ch!='\0')
	{
		*ch -= key;
		ch++;
	}
}
