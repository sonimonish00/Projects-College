using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dbmi_prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = new double[10000];
            Random rnd = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(0,1000);
            }
            for (int j = 0; j < number.Length; j++)
            {
                Console.WriteLine(number[j]);
            }
            using (StreamWriter sr = new StreamWriter(@"E:\monish.txt"))
            {
                foreach (var item in number)
                {
                    //sr.Write(item + " "); -- This is also Valid
                    sr.WriteLine(item);
                }
            }
            Console.Read();

        }
    }
}
