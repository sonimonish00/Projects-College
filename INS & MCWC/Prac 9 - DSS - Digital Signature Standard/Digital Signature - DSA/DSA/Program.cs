using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Numerics;
namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int message = 0;
            string hash = null;
            int p = 23; //303287,7
            int q = 0;
            int g = 0;
            int x = 0;
            int y = 0;
            int h = 0;
            int k = 0;
            int r = 0;
            int s = 0;
            int inv = 0; //For k inverse
            int w = 0;
            int u1 =0;
            int u2 = 0;
            int v = 0;
            Random rnd = new Random();
            Console.WriteLine("Enter Your Hash Message(Numeric Integer Value):-");
            message = Convert.ToInt32(Console.ReadLine());
            //hash = Convert.ToBase64String(new SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(message)));
            //Console.WriteLine("The SHA-1 Hash of Message is:- "+hash);

            //Generating Variables

            //Generating q -> (p-1) mod q = 0
            for (int i = 1; i < p - 1; i++)
            {
                if (((p - 1) % i) == 0)
                {
                    q = i;
                }
            }

            //Generating g from h
            int temp = (p - 1) / q;
            int j = 0;
            for(int i=2;i<(p-1);i++)
            {
                if((Math.Pow(i,temp)%p)>1)
                {
                    h = i;
                    break;
                }
            }
            g = (int)(Math.Pow(h, temp) % p);

            //Generating x - (Private Key) - Used for Encrypting Hash Message(Sender Side) - x is Pseudo Random Number so it depends upon your system clock
            x = rnd.Next(1,q-1); 
            //x = 7;

            //Generating y - (Public Key) - Used for Decryption at Reciever Side
            y = (int)(Math.Pow(g, x) % p);
            
            //Generating k - Random Number Less than q
            k = rnd.Next(q-1);
            //k=5;
            Console.WriteLine("========================================================================");
            Console.WriteLine("The Public Key:{p,q,g,y} is:" +"{" +p +"," +q + "," +g + "," +y + "}");
            Console.WriteLine("The Private Key:{p,q,g,x} is:" + "{" + p + "," + q + "," + g + "," + x + "}\n\n");
            Console.WriteLine("The Random Number k is(Used at Senders Side) :"+k);
            Console.WriteLine("========================================================================\n\n");
            Console.WriteLine("Sender Will Now Generate Digital Signature of Hash Using Private Key....");
            //Calculating r
            r = (int)((Math.Pow(g,k)%p) % q);
            //Calculating k Inverse - inv
            for (int i = 1; i < q-1; i++)
            {
                if ((k* i) % q == 1)
                {
                    inv = i;
                    break;
                }
            }
            //Calculating s from inv and other parameters
            s = (inv * (message + (x * r))) % q;

            Console.WriteLine("The Value of R and S is: {"+r +"," +s+"}");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Reciever Will Now Verify Digital Signature (R,S) With Public Key....");
            //Calculation w b inversing s 
            for (int i = 1; i < q - 1; i++)
            {
                if ((s * i) % q == 1)
                {
                    w = i;
                    break;
                }
            }
            //Calculating u1 and u2
            u1 = (message * w) % q;
            u2 = (r * w) % q;

            //Calculating v 
            v = (int)(((Math.Pow(g,u1)*Math.Pow(y,u2))%p) % q);
            //Checking for Validation
            if (v==r)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Here v==r,So Signature is Succesfully Verified At Reciever's Side.");
            }

            Console.ReadLine();
        }
    }
}
