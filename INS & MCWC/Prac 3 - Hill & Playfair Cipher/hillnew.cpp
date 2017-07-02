#include <iostream>
#include <string.h>
#include <conio.h>
#include <stdlib.h>

#define ROW 2
#define COL 2
using namespace std;

class HillCipher
{
	int arr[ROW][COL];
	char key[10],a[5][5],pt[100],ctchar[100],dtchar[100];
	int length,ct[100],dt[100];
	int i,j,row=0,col=0,x,y,flag=0,len,len1,rem;
	char *grp;
	int *grpofint;
	int adj[ROW][COL];
	int q=0,t[5];
	char aa[26]={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
	
	public: void keymatrix(int arr[ROW][COL])
	{
		cout<<"Enter an Array of "<<ROW<<"X"<<COL<<endl;
		for(int i=0;i<ROW;i++)
		{
			for(int j=0;j<COL;j++)
			{
					cin>>arr[i][j];
			}
		}
		for(int i=0;i<ROW;i++)
		{
			for(int j=0;j<COL;j++)
			{
			    cout<<"Arr["<<i<<"]["<<j<<"] = "<<arr[i][j]<<" ";
			}
			cout<<endl;
		}
		
	}
	public: int display()
	{
		cout<<"Hill Cipher program\n";
		cout<<" option    Functions\n";
		cout<<"-------------------------\n";
		cout<<" [1] Enter The Text & Key\n";
		cout<<" [2] Encrypted Text\n";
		cout<<" [3] Decrypted Text\n";
		cout<<" [4] Exit\n";
		cout<<"-------------------------\n";
		return 0;	
	}
	public: void divison(char pt[])
	{
		len = strlen(pt);
		//case 1:
		if(len%2==0)
		{
			grp = new char[len]();
			for(int i=0;i<len;i=i+2)
			{		
				grp[i] = pt[i];
				grp[i+1] = pt[i+1];
			}
			//Display Testing of Group
			for(int i=0;i<strlen(grp);i++)
			{
				printf("grp[%d] = %c \n",i,grp[i]);
			}
			grpofint = new int[len]();
			length=len;
			//Main For Loop for Converting Characters into Integer
			for(int i=0;i<strlen(grp);i++)
			{
				for(int j=0;j<26;j++)
				{
					if(grp[i]==aa[j])
					
					{
					grpofint[i]=j;
					j=26;
					
					}
				}
			}
			//Display Testing of Group after Conversion
			for(int i=0;i<strlen(grp);i++)
			{
				printf("grp[%d] = %d",i,grpofint[i]);
			}
		}
		//case 2:
		else
		{
				pt[len]={'x'};
		    	
		    	for(i=0;i<=len;i++)
				{		
					printf("pt[%d] = %c \n",i,pt[i]);
				}
				len1 = strlen(pt);
				printf("The Lenght of PT is: %d",len1);
				grp = new char[len1]();
				grpofint = new int[len1]();
				for(i=0;i<len1;i=i+2)
				{		
					grp[i] = pt[i];
					grp[i+1] = pt[i+1];
				}
				
				//Display Testing of Group
				for(i=0;i<len1;i++)
				{
					printf("grp[%d] = %c \n",i,grp[i]);
				}
				printf("\n");
				length=len1;
				//Main For Loop for Converting Characters into Integer
				for(i=0;i<len1;i++)
				{
					for(j=0;j<26;j++)
					{
						if(grp[i]==aa[j])
						
						{
							grpofint[i]=j;
							j=26;
						}
					}
				}
				//Display Testing of Group after Conversion
				for(i=0;i<len1;i++)
				{
					printf("grp[%d] = %d\n",i,grpofint[i]);
				}

		}
	}
	public: void encrypt()
	{
		int temp[2];
		for(int i=0;i<length;)
		{
			temp[0]=(arr[0][0]*grpofint[i])+(arr[0][1]*grpofint[i+1]);
			temp[1]=(arr[1][0]*grpofint[i])+(arr[1][1]*grpofint[i+1]);
			ct[i] = temp[0] % 26;
			ct[i+1] = temp[1] % 26;
			cout<<ct[i]<<endl<<ct[i+1]<<endl<<endl;
			i=i+2;
		}	
		char temp1='a';
		for(int j=0;j<length;j++)
		{
			temp1='a';
			for(int i=0;i<26;i++)
		{
			if(ct[j]==i)
			{break;
			}
			temp1++;			
		}
		ctchar[j]=temp1;
		}
		
		
		printf("Your encrytped text\n");
		for(int i=0;i<length;i++)
		{
			cout<<ctchar[i]<<endl;
			
		}
	}
	public: void decrypt()
	{
	cout<<"Enter Your Key To Decrypt:"<<endl;
		for(int i=0;i<ROW;i++)
		{
			for(int j=0;j<COL;j++)
			{
				cin>>arr[i][j];
			}
		}
		adj[0][0] = arr[1][1];
		adj[0][1] = arr[0][1] * (-1);
		if(adj[0][1]<0)
		{
			adj[0][1] = adj[0][1] + 26;
		}
		adj[1][0] = arr[1][0] * (-1);
		if(adj[1][0]<0)
		{
			adj[1][0] = adj[1][0] + 26;
		}
		adj[1][1]=arr[0][0];
		int det = (arr[0][0] * arr[1][1]) - (arr[0][1] * arr[1][0]);
		if(det<0){
			det+=26;
		}
		cout<<det;
		int end=0;
		for(int i=1;i<=26;i++)
		{
			if( (det*i)%26==1 )
			{
				end=i;
				break;
			}
			end=i;
				
		}
		cout<<endl<<end;
		if(end>=26)
		{
			cout<<"This Key Could not be Apply..Please apply another key\n";
			exit(0);
		}
		for(int i=0;i<ROW;i++)
		{
			for(int j=0;j<COL;j++)
			{
				adj[i][j]=adj[i][j] * end;
				adj[i][j]=adj[i][j] % 26;
			}
		}
		
		int temp[2];
		for(int i=0;i<length;)
		{
			temp[0]=(adj[0][0]*ct[i])+(adj[0][1]*ct[i+1]);
			temp[1]=(adj[1][0]*ct[i])+(adj[1][1]*ct[i+1]);
			dt[i] = temp[0] % 26;
			dt[i+1] = temp[1] % 26;
			cout<<dt[i]<<endl<<dt[i+1]<<endl<<endl;
			i=i+2;
		}	
		char temp1='a';
		for(int j=0;j<length;j++)
		{
			temp1='a';
			for(int i=0;i<26;i++)
		{
			if(dt[j]==i)
			{break;
			}
			temp1++;			
		}
		dtchar[j]=temp1;
		}
		
		
		printf("Your decrytped text\n");
		for(int i=0;i<length;i++)
		{
			cout<<dtchar[i]<<endl;
			
		}
		
	}
	public: int select(int c)
	{
		int i;
		switch(c)	
		{
			case 1:
				{
				system("cls");
				display();
				fflush(stdin);
				cout<<"Enter Plain Text:";
				gets(pt);
				
				cout<<"Enter Key: \n";
				//Generating and printing of Key Matrix is Done
				keymatrix(arr);
				divison(pt);
				getch();
				break;
				}
				case 2:
				{
					system("cls");
					display();
					encrypt();
					getch();
					break;
				}
				case 3:
				{
					system("cls");
					display();
					decrypt();
					getch();
					break;
				}
				case 4: 
				break;
		}
		return c;
	}
};

int main()
{
	int c;
	HillCipher h1;
		do{
			system("cls");
			loop:
			h1.display();
			cout<<"Enter Your Choice:";
			cin>>c;
		if(c>4 || c<1)
		{
			system("cls");
			cout<<"\nEnter proper value!!!!!!!!!!!!!!!!!\n";
			goto loop;
		}
		h1.select(c);
	 }
	 while(c!=4);
	getch();
	return 0;
}
