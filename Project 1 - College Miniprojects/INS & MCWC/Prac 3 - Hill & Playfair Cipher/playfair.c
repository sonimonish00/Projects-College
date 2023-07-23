#include <stdio.h>
#include <conio.h>
#include <string.h>
	
	//Intializations
	char key[10],a[5][5],pt[100],ct[100],rf[100];
	int i,j,row=0,col=0,x,y,flag=0,l;
	
	void decrypt(char key[],char ct[])
	{
		printf("\n ciphertxt: %s\n",ct);
		printf("\n plaintext: ");
		j=1;
		for(i=0;i<strlen(pt)-1;)
		{
			int r1=0,c1=0,r2=0,c2=0,p=0,q=0;
			x=ct[i];
			y=ct[j];
	
			if(x=='j') 
				ct[i]='i';
			if(y=='j') 
				ct[j]='i';
	
			for(p=0;p<5;p++)
			{
				for(q=0;q<5;q++)
				{
					if(a[p][q]==x)	
					{
						r1=p;
						c1=q;
					}
	
					if(a[p][q]==y)	
					{
						r2=p;
						c2=q;
					}
				}
			}
	
			if(r1==r2)
			{
				rf[i]=a[r1][(c1-1)%5];
				rf[j]=a[r2][(c2-1)%5];
				printf("%c%c",rf[i],rf[j]);
			}
			else if(c1==c2)
			{
				rf[i]=a[(r1-1)%5][c1];
				rf[j]=a[(r2-1)%5][c2];
				printf("%c%c",rf[i],rf[j]);
			}
			else
			{
			       rf[i]=a[r1][c2];
			       rf[j]=a[r2][c1];
			       printf("%c%c",rf[i],rf[j]);
			}
			i+=2;
			j+=2;
		}
		getch();
}
	void encrypt(char key[],char pt[] )
	{
		printf("\n plaintext: %s\n",pt);
		printf("\n ciphertext: ");
		j=1;
		
		for(i=0;i<strlen(pt)-1;)
		{
			int r1=0,c1=0,r2=0,c2=0,p=0,q=0; //p,q are for 2-D ,r1,r2,c1,c2 are rows and cols.
			x=pt[i];//Step
			y=pt[j];//One Step Ahead - Because algo. works on each letter of pair
	
			if(x=='j') //Replacing j with i in Plaintext
			pt[i]='i';
			
			if(y=='j') //Same With One Step Ahead in plaintext
			pt[j]='i';
			
			for(p=0;p<5;p++) //For Creating 2-D Matrix Loop
			{
				for(q=0;q<5;q++)
				{
					if(a[p][q]==x) //a[0][0] = plaintext[0] ie. if first letter of PT matches with first letter in Key Matrix 2D Array
					{
						r1=p; //mark the position r1 & c1 with of p & q if the first letter in PT is found in first pos. of a[][]
						c1=q; 
					}
					if(a[p][q]==y) //a[0][0] = plaintext[1] ie. if 2nd letter of PT matches with first letter in Key Matrix 2D Array
					{
						r2=p; 
						c2=q; 
					}
				}
			}
	
			if(r1==r2) //if letters appears on the same row then replace them with the letters to their immediate right respectively
			{
				ct[i]=a[r1][(c1+1)%5];
				ct[j]=a[r2][(c2+1)%5];
				printf("%c%c",ct[i],ct[j]);
			}
			else if(c1==c2) //if letters appears on the same column then replace them with the letters to their immediate right respectively
			{
				ct[i]=a[(r1+1)%5][c1];
				ct[j]=a[(r2+1)%5][c2];
				printf("%c%c",ct[i],ct[j]);
			}
			else //f the letters are in different rows and columns 
			{	//replace the pair with the letters on the same row respectively but at the other pair of corners of the rectangle defined by the original pair.
				   ct[i]=a[r1][c2];
			       ct[j]=a[r2][c1];
			       printf("%c%c",ct[i],ct[j]);
			}
			i+=2; //For Keep Moving Forward
			j+=2; //So that j Remains 1 step ahead
		}
		getch();
	}
	int display()
	{
		printf("Playfair Cipher program\n");
		printf("-----------------------\n");
		printf(" option    Functions\n");
		printf("-----------------------\n");
		printf("  [1]    Enter The Text\n");
		printf("  [2]    Encrypted Text\n");
		printf("  [3]    Decrypted Text\n");
		printf("  [4]    Exit\n");
		printf("-----------------------\n");
		return 0;
	}
	
	void keydisplay()
	{
		//First For Loop upto length of key : For filling up intially in matrix
		for(i=0;i<strlen(key);i++)	
		{
			//Intially Flag is set to 1
			flag=1;
			//Again a For Loop upto 1 Length less than key : ex: "play" so upto a
			for(j=0;j<i;j++)
			{
				//if the Next Character is Same then set Flag=0,We are Eliminating the Duplicate Character from Key String
			   if(key[i]==key[j])	
			   flag=0;
			}
	
			if(flag==1)    //If No Duplicacies are found in the key,Start Filling the Table. Ex: play
			{
				a[row][col]=key[i]; //Value of 1-D into 2-D
				printf(" %c",a[row][col]); //Displaying the Same in matrix
				col++; //Next Value in Row
				if(col==5) //For Next Line Stops at 5th Column
				{
					printf("\n");
					col=0; //Resetting Column Value to Start again for next Row
					row=row+1;
				}
	        }
		}
		//Second For Loop upto 26 Characters in Length to Fill up the Remaining Space after key into table
	for(i=0;i<26;i++)
	{ 
		flag=1; //same as above
		for(j=0;j<strlen(key);j++)
		{
			if(key[j]==i+97)	//ASCII 97 - a(small) ; so if first letter in key is 'a' then set flag=0
			flag=0;
		}
		if(flag==1 && i!=9)	// 9 stands for 'i' (ASCII-105) ; So if flag is 1 and position value is not i then procedd 
		{
			a[row][col]=i+97; //starting from abc.... again to fill up the gap in table matrix
			printf(" %c",a[row][col]);
			col++;
			if(col==5) //same logic as above
			{
				row=row+1;
				col=0;
				printf("\n");
			}
		}
	}
	
	}

	int select(int c)
	{
	int i;
	switch(c)	
	{
			case 1:
			{
				system("cls");
				
				display();
				fflush(stdin);
				
				printf("Enter the Plain Text:");
				gets(pt);
				l=strlen(pt); //Storing For Future Use
				
				printf("Enter key:\n ");
				gets(key);
				
				for(i=0;i<strlen(key);i++)
				{
					//Replacing J with I in Key
					if(key[i]=='j')
					   key[i]='i';
				}
				//Intializing all the Positions of Cipher Text Array with null Value
				for(i=0;ct[i]!='\0';i++)
					ct[i]='\0';
					
				break;
			}
		case 2:
		{
			system("cls");
			display();
			
			keydisplay();
			encrypt(key,pt);
			
			break;
		}
		case 3:{
			system("cls");
			display();
			
			keydisplay();
			decrypt(key,ct);
			
			break;
			}
		case 4: break;
	}
	return c;	
}
	
void main()
{
	int c;
		do{
			system("cls");
			f1:
			display();
			printf("Enter Your Choice:");
			scanf("%d",&c);
		if(c>4 || c<1){
			system("cls");
			printf("\nEnter proper value\n");
			goto f1;
		}
		select(c);
	 }while(c!=4);

	//Ending Formalities
	getch();
}

