using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apriori_DMBI
{
    class Program
    {
        //int row = pair.GetLength(0);
        //int col = pair.GetLength(1);
        //for (int i = 0; i < row; i++) storing
        //{
        //    for (int j = 0; j < col; j++)
        //    {
        //        pair[i,j] =Convert.ToString(0);
        //    }                
        //}

        //for (int i=0;i<row;i++) printing
        //{
        //    for(int j=0;j<col;j++)
        //    {
        //        Console.Write(string.Format("{0} ", pair[i, j]));
        //    }
        //    Console.Write(Environment.NewLine + Environment.NewLine);
        //}

        static void Main(string[] args)
        {
            string[][] Transaction = new string[5][] { new string[] { "M", "O", "N", "K", "E", "Y" }, new string[] { "D", "O", "N", "K", "E", "Y" }, new string[] { "M","A","K","E" }, new string[] { "M","U","C","K","Y" }, new string[] { "C","O", "O", "K", "I", "E" } };
            string[] allchars = {"M","O", "N", "K", "E", "Y", "D", "A", "U", "C", "I"};
            var count = 0;
            int total_Count = 0;
            int[] no_of_transaction= new int[11];

            int[] new_trans = new int[11];
            string[] new_char = new string[11];

            int[] new_trans1 = new int[5];
            string[] new_char1 = new string[5];


            // Step 1: Intital Inputs Display ----
            Console.WriteLine("Displaying Intial Inputs on Transaction :\n");
            Console.WriteLine("T ID : Items\n");

            for (int i=0;i<Transaction.Length;i++)
            {
                string[] innnerarray = Transaction[i];
                Console.Write("T["+(i+1)+"] : ");
                for (int a=0;a<innnerarray.Length;a++)
                {
                    Console.Write(innnerarray[a]+" ");
                }                
                Console.WriteLine();
            }

            // Step 2: Displaying Next Table 
            for (int i = 0; i < Transaction.Length; i++) 
            {
                string[] innnerarray = Transaction[i]; 
                for (int j = 0; j < allchars.Length; j++)
                { 
                    for (int a = 0; a < innnerarray.Length; a++)
                    {
                        count = innnerarray.Count(s=>s.Contains(allchars[j]));// How many MONKEYDAUCI in 1st Array of Transaction Arrays 
                        if (count > 1) { count = count - 1; }
                    }
                    //Console.WriteLine("The Letter "+allchars[j]+" Occurs "+count+" Time(s) in "+i+" Element of Transaction Array");
                    total_Count += count; 
                    no_of_transaction[j] += count;
                }
                //Console.WriteLine();
            }
            Console.WriteLine("\nDisplaying Number of Transaction :");
            Console.WriteLine("Item : No. Of Trans.");
            //Console.WriteLine("Total Characters Count is : "+ total_Count);
            //Printing the Table
            for (int i = 0; i < allchars.Length; i++)
            {
                Console.WriteLine(allchars[i]+"-"+no_of_transaction[i]);
            }
            //New Char[] && New Trans[] storing
            for (int i = 0; i < no_of_transaction.Length;i++)
            {
                if (no_of_transaction[i] >= 3) //Taking All Elements Greater than =3
                {
                    new_char[i] = allchars[i]; 
                    new_trans[i] = no_of_transaction[i];
                }
            }
            int flag = 0;
            //Storing into New trans1 and new char1 again finally.
            for (int i = 0; i < new_trans.Length; i++)
            {
                if (new_trans[i]!=0) //Rewriting the Values with 0 Values
                {
                    new_trans1[flag] = new_trans[i]; //3
                    new_char1[flag] = new_char[i]; //m
                    flag ++;
                } 
            }
            Console.WriteLine("================Printing VALUE : LEVEL 1 ================================");
            for(int i=0;i<new_trans1.Length;i++)
            {
                Console.WriteLine(new_char1[i] + "-" + new_trans1[i]);
            }
            /// -----------------------------------REPEAT THIS MODULE AGAIN IN FUTURE-----------------------------------------
            string[,] pair = new string[10,2];
            int row = pair.GetLength(0);
            int col = pair.GetLength(1);
            string temp = null;
            int count1 = 0;
            //Making Pair and Storing Them into Pair 1st Column
            for (int i=0;i<new_char1.Length;i++)
            {
                temp = new_char1[i]; 
                for(int j=(i+1);j<new_char1.Length;j++)
                {
                    pair[count1, 0] = temp + new_char1[j];
                    count1++;
                }
            }
            //Counting the Pair No. of Transactions for LEVEL 2
            int counter;
            string strtemp = null;
            string subtemp = null;
            string subtemp2 = null;
            string name = null;
            int[] level2 = new int[10];
            //Main Logic For Two Pair Counting of Number of Transaction ------------------>>> USEFUL FOR LEVEL 4
            for (int i = 0; i < row; i++)
            {
                strtemp = pair[i,0]; // OK
                subtemp =  strtemp.Substring(0,1); //O
                subtemp2 = strtemp.Substring(1, 1); //K 
                counter = 0;
                name = null;
                for (int j=0;j<Transaction.Length;j++)
                {
                    string[] innerarr = Transaction[j];
                    name = null;
                    for(int k=0;k<innerarr.Length;k++)
                    {
                        name += innerarr[k];
                    }
                    if (name.Contains(subtemp) && name.Contains(subtemp2))
                    {
                        counter += 1;
                    }
                }
                level2[i] = counter;
            }
            for (int i = 0; i < level2.Length; i++) //Storing the Number of Transaction Integer Value in Pair
            {
                pair[i,1] = level2[i].ToString();
            }
            Console.WriteLine("=================PRINTING LEVEL 2==============================");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", pair[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            ///-----------------------STARTING OF LEVEL 3---------------------------------------
            string[,] triple = new string[5, 2];
            int row1 = triple.GetLength(0);
            int col1 = triple.GetLength(1);
            int k9 = 0;

            for (int i=0;i<10;i++)
            {
                if (Convert.ToInt32(pair[i, 1]) >=3)
                {
                    triple[k9, 0] = pair[i, 0];
                    triple[k9, 1] = pair[i, 1];
                    k9++;
                }
            }
            Console.WriteLine("=================PRINTING LEVEL 3==============================");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(string.Format("{0} ", triple[i, j]));
                }
                Console.WriteLine();
            }
            //Self Join : Finding 2 Pairs With Same 1st Alphabet.
            int flag1 = 0;
            string tripletemp = null;
            string subtripletemp = null;

            string tripletemp1 = null;
            string subtripletemp2 = null;
            string subtripletemp3 = null;

            string final = null;
            string[,] triple1 = new string[2, 2];
            int row2 = triple1.GetLength(0);
            int col2 = triple1.GetLength(1);

            for (int i =0;i<row1;i++)
            {
                tripletemp = triple[i,0]; //MK
                subtripletemp = tripletemp.Substring(0,1); //M
                for (int j = i + 1; j < row1; j++) //May Be row1-1
                {
                    tripletemp1 = triple[j,0]; //OK
                    subtripletemp2 = tripletemp1.Substring(0,1); //O
                    subtripletemp3 = tripletemp1.Substring(1,1); //K
                    if (subtripletemp==subtripletemp2) // Is M=O ??
                    {
                        final = tripletemp + subtripletemp3;
                        triple1[flag1, 0] = final;
                        flag1++;
                    }
                }
            }
            Console.WriteLine("=================PRINTING LEVEL 4==============================");


            //Now We Had to Find the Number of Transaction for this Elements
            //Apply The Main Logic Again Here
            string subtemp3 = null;
            int[] level3 = new int[2];
            for (int i = 0; i < row2; i++)
            {
                strtemp = triple1[i, 0]; // OK
                subtemp = strtemp.Substring(0, 1); //O
                subtemp2 = strtemp.Substring(1, 1); //K 
                subtemp3 = strtemp.Substring(2, 1); //E
                counter = 0;
                name = null;
                for (int j = 0; j < Transaction.Length; j++)
                {
                    string[] innerarr = Transaction[j];
                    name = null;
                    for (int k = 0; k < innerarr.Length; k++)
                    {
                        name += innerarr[k];
                    }
                    if (name.Contains(subtemp) && name.Contains(subtemp2) && name.Contains(subtemp3))
                    {
                        counter += 1;
                    }
                }
                level3[i] = counter;
            }
            for (int i = 0; i < level3.Length; i++) //Storing the Number of Transaction Integer Value in Pair
            {
                triple1[i, 1] = level3[i].ToString();
            }
            for (int i = 0; i < row2; i++) //Printing The Level 5
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write(string.Format("{0} ", triple1[i, j]));  //OKE - 0
                }
                Console.WriteLine();
            }
            ///-----------------------------------------------------------------------------------------
            string[,] finalans = new string[1, 2];
            int row3 = finalans.GetLength(0);
            int col3 = finalans.GetLength(1);
            int AK47 = 0;

            for (int i = 0; i < row3; i++)
            {
                if (Convert.ToInt32(triple1[i, 1]) >= 3)
                {
                    finalans[AK47, 0] = triple1[i, 0];
                    finalans[AK47, 1] = triple1[i, 1];
                    AK47++;
                }
            }
            Console.WriteLine("=================PRINTING LEVEL 5==============================");
            for (int i = 0; i < row3; i++)
            {
                for (int j = 0; j < col3; j++)
                {
                    Console.Write(string.Format("{0} ", finalans[i, j]));
                }
                Console.WriteLine();
            }
            //Ending Formality
            Console.ReadLine();
        }
    }
}
