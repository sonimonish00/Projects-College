using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Numerics;

namespace Digital_Signature_RSA
{
    // MD5 hash:
    //string h2 = Convert.ToBase64String(new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes("one two")));
    class Program
    {
        public static void encryption(string plain1, int privatekey, int N)
        {
            BigInteger pt = 0;
            int flag = 0;
            string finalval = null;
            BigInteger[] temp = new BigInteger[100];
            char[] temp1 = new char[100];
            byte[] ascii = Encoding.ASCII.GetBytes(plain1);
            foreach (Byte b in ascii)
            {
                pt = BigInteger.Parse(b.ToString());
                temp[flag] =(BigInteger.Pow(pt, privatekey))%N;
                temp1[flag] = (char)temp[flag];
                flag++;
            }
            finalval = new string(temp1);
            Console.WriteLine("Your Digital Signature is:" + finalval);
        }
        public static void decryption(int privatekey, string cipher, int N,string original)
        {
            string plaintext = null;
            BigInteger ci = 0, val = 0;
            int flag = 0;
            char[] plain = new char[100];
            byte[] ascii = Encoding.ASCII.GetBytes(cipher);
            foreach (Byte b in ascii)
            {
                ci = BigInteger.Parse(b.ToString());
                val = BigInteger.Pow(ci, privatekey);
                plain[flag] = (char)(val % N);
                flag++;
            }
            plaintext = new string(plain).Replace("\0", string.Empty);
            Console.WriteLine("After Decryption of C.T. Message Digest(MD1) is: " + plaintext);
            Console.WriteLine("Now Calculating SHA - 1 (MD2) of Original Message: "+original);
            original = Convert.ToBase64String(new SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(original)));

            Console.WriteLine("The SHA - 1 (MD2) of Original Message is: "+original);
            int result = string.Compare(original, plaintext,false);
            if (result==0)
            {
                Console.WriteLine("Message Succesfully Digitally Verified !!");
            }
        }
        public static int publickey(int p, int q, int N)
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
            // SHA1 hash:
            string h1 = null, original = null;
            int p, q, N;
            int privatekey = 1;
            int pubk = 0;
            int ch = 0;
            string plain=null, cipher=null;
            Console.WriteLine("Enter 1st Prime Number :");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Prime Number :");
            q = int.Parse(Console.ReadLine());
            int phi_N = (p - 1) * (q - 1);
            N = p * q;
            pubk = publickey(p, q, N);
            for (;;)
            {
                if ((privatekey * pubk) % phi_N == 1)
                {
                    break;
                }
                else
                {
                    privatekey++;
                }
            }

            Console.WriteLine("The Private key is :" + privatekey + "\nThe Public Key is:" + pubk + "\n");

            while (ch != 3)
            {
                Console.WriteLine("Enter Your Choice :");
                Console.WriteLine("1. ENCRYPTION");
                Console.WriteLine("2. SIGNATURE VERIFICATION");
                Console.WriteLine("3. Exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Your Original Message:");
                        h1 = Console.ReadLine();
                        plain=Convert.ToBase64String(new SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(h1)));
                        Console.WriteLine("SHA-1 is:"+plain); //Printing SHA1
                        encryption(plain, privatekey, N);
                        break;

                    case 2:
                        Console.WriteLine("Enter Your Cipher Text to Decyrpt Using Sender's Public Key :");
                        cipher = Console.ReadLine();

                        Console.WriteLine("Enter Your Plain Text - Original Message :");
                        original = Console.ReadLine();

                        decryption(pubk, cipher, N,original);
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
