using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace dmbi_Prac3
{
    class Program
    {
        //MIN-MAX NORMALIZATION

        static float MinMax(float v,int[] array,int len,float r_min,float r_max)
        {
            float min, max,ans=0;
            min = array[0];
            max = array[len-1];
            ans = ((v - min) / (max - min)) * (r_max - r_min) + r_min;
            return ans;
        }

        //Z-SCORE NORMALIZATION
        static float zscore(float v, int[] array, int len)
        {
            float ans = 0, sd = 0, mean = 0, total = 0;
            for (int i = 0; i < len; i++)
            {
                total = total + array[i];
            }
            mean = total / len;  //finding XMean of given array 
            for (int i = 0; i < len; i++)
            {
                sd = sd + ((array[i] - mean) * (array[i] - mean));
            }
            sd = sd / len;
            sd = (float)Math.Sqrt(sd);  // Final Sandard deviation.   
            ans = (v - mean) / sd;  //Final Ans of Z Score  
            return ans;
        }

        //Decimal Power NORMALIZATION
        static void dec(int v, int[] array, int len)
        {
            float power = 10;
            for (int i = 1; i < v; i++)
            {
                power = power * 10;
            }

            Console.WriteLine("After Normalization Value are : ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i]/power);
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 13, 15, 16, 16, 19, 20, 20, 21, 22, 22, 25, 25, 25, 25, 30, 33, 33, 35, 35, 35, 35, 36, 40, 45, 46, 52, 70 };
            int len = arr.Length;
            int ch=0;
            Console.WriteLine("-------------Normalization Program--------------");
            while (ch != 4)
            {
                Console.WriteLine("Enter Your Choice :");
                Console.WriteLine("1. Min-Max Normalization");
                Console.WriteLine("2. Z-Score Normalization");
                Console.WriteLine("3. Decimal Scaling Normalization");
                Console.WriteLine("4. Exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        float ans = 0, n = 0, min = 0, max = 0;
                        Console.WriteLine("Enter Value to Normalize : ");
                        n = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Minimum Value to Normalize Range : ");
                        min = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Maximum Value to Normalize Range : ");
                        max = float.Parse(Console.ReadLine());
                        ans = MinMax(n, arr, len, min, max);
                        Console.WriteLine("Your Answer is :" + ans);
                        break;

                    case 2:
                        float ans1 = 0, n1 = 0;
                        Console.WriteLine("Enter Value to Normalize : ");
                        n1 = float.Parse(Console.ReadLine());
                        ans1 = zscore(n1, arr, len);
                        Console.WriteLine("Your Answer is :" + ans1);
                        break;

                    case 3:
                        int n2 = 0;
                        Console.WriteLine("Enter Decimal Power to Normalize i,(10^i) : ");
                        n2 = int.Parse(Console.ReadLine());
                        dec(n2, arr, len);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Correct Choice!!");
                        break;
                }
            }
        }
    }
}
