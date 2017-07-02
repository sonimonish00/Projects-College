using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    class Program
    {
        static void encryption(int plain, int pubk, int N)
        {
            double cipher;
            double pt = Convert.ToDouble(plain);
            double pub = Convert.ToDouble(pubk);
            double val = Math.Pow(pt,pub);
            cipher = val % N;
            Console.WriteLine("Your Cipher Text is:"+cipher);
        }
        static void decryption(int privatekey, int cipher, int N)
        {
            BigInteger ci = BigInteger.Parse(cipher.ToString());
            BigInteger val = BigInteger.Pow(ci,privatekey);
            BigInteger plain = val % N;
            Console.WriteLine("Your Plain Text is:" + plain);
        }
        static int publickey(int p,int q,int N)
        {
            int phi_N = (p - 1) * (q - 1);
            int publickey = 0;
            for (int x = 1; x <= phi_N; x++)

            {
                if (phi_N % x != 0)
                {
                    publickey = x;
                    break;
                }

            }
            return publickey;
        }
        static void Main(string[] args)
        {
            int p,q,N;
            int privatekey=1;
            int pubk = 0;
            int ch = 0;
            int plain, cipher;
            Console.WriteLine("Enter 1st Prime Number :");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Prime Number :");
            q = int.Parse(Console.ReadLine());
            int phi_N = (p - 1) * (q - 1);
            N = p * q;
            pubk=publickey(p,q,N);
            for(;;)
            {
                if((privatekey*pubk)%phi_N==1)
                {
                    break;
                }
                else
                {
                    privatekey++;
                }
            }

            Console.WriteLine("The Private key is :"+privatekey+"\nThe Public Key is:"+pubk+"\n");
        
            while(ch!=3)
            {
                Console.WriteLine("Enter Your Choice :");
                Console.WriteLine("1. ENCRYPTION");
                Console.WriteLine("2. DECRYPTION");
                Console.WriteLine("3. Exit");
                ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Enter Your Message:");
                        plain = int.Parse(Console.ReadLine());
                        encryption(plain,pubk,N);
                        break;
                    case 2:
                        Console.WriteLine("Enter Your Cipher Text:");
                        cipher = int.Parse(Console.ReadLine());
                        decryption(privatekey,cipher,N);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Correct Choice!!");
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
