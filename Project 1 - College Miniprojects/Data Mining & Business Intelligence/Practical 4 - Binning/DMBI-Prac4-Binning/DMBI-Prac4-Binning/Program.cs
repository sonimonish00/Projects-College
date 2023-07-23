using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMBI_Prac4_Binning
{
    class Program
    {
        static void average(int[][] arr,int size,int rows)
        {
            int sum = 0,avg=0;
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sum = sum + arr[i][j];
                }
                avg = sum/size;
                for (int j = 0; j < size; j++)
                {
                    Console.Write("A[{0}][{1}] = {2}", i, j, avg);
                    Console.Write(" ");
                }
                avg = 0;sum =0;
                Console.WriteLine();
            }
        }

        static void mean(int[][] arr, int size, int rows)
        {
            int mean = 0;
            int temp;
            for (int i = 0; i < rows; i++) //For Each Row
            {
                for (int j = 0; j < size; j++) //For Each Column in that Row
                {
                    if ((size % 2) != 0) //For odd Number of Length
                    {
                        mean = size / 2; 
                        temp = arr[i][mean]; 
                    }
                    else  //For Even Number of Length
                    {
                        mean = size / 2; 
                        temp = (arr[i][mean] + arr[i][mean-1]) / 2;
                    }
                    Console.Write("A[{0}][{1}] = {2}", i, j, temp);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void boundary(int[][] arr, int size, int rows)
        {
            int temp;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (((arr[i][j] - arr[i][0]) <= (arr[i][size - 1] - arr[i][j]))) //4,5,6,7,9,10  : 0 <= 6
                    {
                        temp = arr[i][0]; //Taking First Value in Array
                    }
                    else
                    {
                        temp = arr[i][size - 1]; //Taking Last Value in Array
                    }
                    Console.Write("A[{0}][{1}] = {2}", i, j, temp);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
     static void Main(string[] args)
        {
            //Decalarations
            int num, size,choice=0;
            Random rnd = new Random();

            Console.WriteLine("Enter Total Number of Elements : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bin Size (The Maximum Elements that could be in 1 Bin) : ");
            size = int.Parse(Console.ReadLine());
            
            int rows = num / size;  // 10/2=5==> 5 Rows and 2 Cols.
            //////////////////////////////////////////////////////
            int[][] arr = new int[rows][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[size];
            }

            //int[][] mean_arr = new int[rows][];
            //for (int i = 0; i < mean_arr.Length; i++)
            //{
            //    mean_arr[i] = new int[size];
            //}

            //int[][] bound_arr = new int[rows][];
            //for (int i = 0; i < bound_arr.Length; i++)
            //{
            //    bound_arr[i] = new int[size];
            //}
            // Generating Random Numbers into Arrays
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i][j] = rnd.Next(0,10);
                }
            }
            //Sorting of Array
            for (int i = 0; i < rows; i++)
            {
                Array.Sort(arr[i]);
            }
            //Display of ARRAY
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("A[{0}][{1}] = {2}", i, j, arr[i][j] +" ");
                }
                Console.WriteLine();
            }

            while (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Enter Your Choice :");
                Console.WriteLine("1. Average Bin Smoothing");
                Console.WriteLine("2. Mean Bin Smoothing");
                Console.WriteLine("3. Boundary Bin Smoothing");
                Console.WriteLine("4. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        average(arr,size,rows);
                        break;
                    case 2:
                        mean(arr,size,rows);
                        break;
                    case 3:
                        boundary(arr,size,rows);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter Correct Choice...");
                        break;
                }

            }
            Console.Read(); //Final Line
        }
    }
}
