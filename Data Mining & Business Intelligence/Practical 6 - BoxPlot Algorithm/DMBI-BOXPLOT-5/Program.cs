using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMBI_BOXPLOT_5
{
    class Program
    {
        static int Median(int[] array)
        {
            int i=array.Length / 2;
            return array[i];
        }
        static void Main(string[] args)
        {
            int q1, q2, q3;
            int iqr = 0;
            float lb=0, ub=0;
            int[] array = new int[9] {3,18,19,25,24,23,20,56,26};
            int[] array1 = new int[9];
            int[] outliers = new int[5];
            int flag = 0,k=0;
            Array.Sort(array);

            //Printing the Sorted Array
            Console.WriteLine("The Sorted Array is : ");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //Finding Median for Q2
            q2 = Median(array);

            //Finding Median for Q1 & Q3
            q1 = array[array.Length/4];
            q3 = array[(array.Length*3)/4];
            iqr = q3 - q1;
            lb = (float)(q2 - (1.5 * iqr));
            ub = (float)(q2 + (1.5 * iqr));
            Console.WriteLine("The Q2 Values is :"+q2 +"\nThe Q1 Value is:"+q1+"\nThe Q3 Value is:"+q3);
            Console.WriteLine("\n\nThe Value of LB is: "+lb +"\nThe Values of UB is:"+ub);
            foreach(int i in array)
            {
                if(i>=14 && i<=32)
                {
                    array1[flag] = i;
                    flag++;
                }else
                {
                    outliers[k] = i;
                    k++;
                }
            }
            
            foreach (int i in outliers)
            {
                if (i > 0)
                {
                    Console.WriteLine("The Outliers Are:"+i);
                }
            }
            //Display The Value With Upper Bound and Lower Bound and Title it smoothing
            Console.WriteLine("\n\nApplying Smoothing to the Data Gives Us:");
            Console.WriteLine(lb);
            foreach (int i in array1)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Write(ub);
            Console.ReadLine();
        }
    }
}
