using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac5
{
    class Program
    {
        
        
        public static void Main(string[] args)
        {
            
            char[] input = new char[6];
            char[] input1 = new char[6];

            Console.WriteLine("Enter Value of V1: ");
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadKey().KeyChar;
            }
            string s = new string(input);
            
            Console.WriteLine("\nEnter Value of V2: ");
            for (int i = 0; i < input1.Length; i++)
            {
                input1[i] = Console.ReadKey().KeyChar;
            }
            string s1 = new string(input1);
            int count = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] != input1[j])
                {
                    count++;
                }
            }
            
            Console.WriteLine("\nThe Value of V1 and V2 is : " + s +" " +s1);
            Console.WriteLine("\nThe result is : " +count);
            Console.ReadKey();
        }
    }
}
