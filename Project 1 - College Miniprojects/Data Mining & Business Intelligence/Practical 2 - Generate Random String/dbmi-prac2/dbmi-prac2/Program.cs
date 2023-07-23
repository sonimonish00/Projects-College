using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmi_prac2
{

    class Program
    {

        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] num = new int[1000,25];
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    num[i, j] = rnd.Next(0, 100);
                }
            }
            
            int[] temp = new int[25];
            using (StreamWriter sr = new StreamWriter(@"E:\monish.txt"))
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 25; j++)
                     {
                        temp[j] = num[i, j];
                     }
                    Array.Sort(temp);

                    for (int j = 0; j < 25; j++)
                    {
                        Console.Write(temp[j]);
                        sr.Write(temp[j] + " ");
                    }
                    sr.WriteLine(" ");
                }

            }
            
            Console.Read();
        }
        
    }
}
