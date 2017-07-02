using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHA_1
{
    class Program
    {
        //static IEnumerable<string> Split(string str, int chunkSize)
        //{
        //    return Enumerable.Range(0, str.Length / chunkSize)
        //        .Select(i => str.Substring(i * chunkSize, chunkSize));
        //}
        static string[] SplitIntoChunks(string toSplit, int chunkSize)
        {
            int stringLength = toSplit.Length;

            int chunksRequired = (int)Math.Ceiling((decimal)stringLength / (decimal)chunkSize);
            var stringArray = new string[chunksRequired];

            int lengthRemaining = stringLength;

            for (int i = 0; i < chunksRequired; i++)
            {
                int lengthToUse = Math.Min(lengthRemaining, chunkSize);
                int startIndex = chunkSize * i;
                stringArray[i] = toSplit.Substring(startIndex, lengthToUse);

                lengthRemaining = lengthRemaining - lengthToUse;
            }

            return stringArray;
        }
        public static string IntToBinaryString(int number)
        {
            const int mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                // Logical AND the number and prepend it to the result string
                binary = (number & 1) + binary;
                number = number >> 1;
            }

            return binary;
        }
        public static string leftRotateShift(string key, int shift)
        {
            shift %= key.Length;
            return key.Substring(shift) + key.Substring(0, shift);
        }
        public static string calcXor(string a, string b)
        {
            int[] charAArray = new int[32];
            int[] charBArray = new int[32];
            int[] result = new int[32];

            for (int i =0;i<a.Length;i++)
            { 
                charAArray[i] = (int)Char.GetNumericValue(a[i]);
            }
            for (int i = 0; i <b.Length; i++)
            {
                charBArray[i] = (int)Char.GetNumericValue(b[i]);
            }
            
            for (int i = 0; i <a.Length; i++)
            {
                result[i] = (charAArray[i] ^ charBArray[i]); 
            }
            string result1 = string.Join("", result);
            return result1;
        }
        public static string calcAnd(string sr1, string sr2)
        {
            char[] crArray1 = sr1.ToCharArray();
            char[] crArray2 = sr2.ToCharArray();
            StringBuilder srResult = new StringBuilder();

            for (int i = 0; i < crArray1.Length; i++)
            {
                if (crArray1[i] == crArray2[i])
                {
                    srResult.Append(crArray1[i]);
                }
                else
                {
                    srResult.Append('0');
                }
            }
            return srResult.ToString();
        }
        public static string calcOR(string sr1, string sr2)
        {
            char[] crArray1 = sr1.ToCharArray();
            char[] crArray2 = sr2.ToCharArray();
            StringBuilder srResult = new StringBuilder();

            for (int i = 0; i < crArray1.Length; i++)
            {
                if (crArray1[i] == '1' || crArray2[i] == '1')
                {
                    srResult.Append("1");
                }
                else
                {
                    srResult.Append('0');
                }
            }
            return srResult.ToString();
        }
        public static string calcNOT(string sr1)
        {
            char[] crArray1 = sr1.ToCharArray();
            StringBuilder srResult = new StringBuilder();

            for (int i = 0; i < crArray1.Length; i++)
            {
                if (crArray1[i] == '0')
                {
                    srResult.Append("1");
                }
                else
                {
                    srResult.Append('0');
                }
            }
            return srResult.ToString();
        }
        public static string calcADD(string a,string b)
        {
            //char[] crArray1 = sr1.ToCharArray();
            //char[] crArray2 = sr2.ToCharArray();
            //StringBuilder srResult = new StringBuilder();

            //for (int i = 0; i < crArray1.Length; i++)
            //{
            //    if (crArray1[i] == '0')
            //    {
            //        srResult.Append("1");
            //    }
            //    else
            //    {
            //        srResult.Append('0');
            //    }
            //}
            ////return srResult.ToString();
            //int number_one = Convert.ToInt32(sr1, 2);
            //int number_two = Convert.ToInt32(sr2, 2);

            //return Convert.ToString(number_one + number_two, 2);
            if (a.Length < b.Length)
            {
                string c = a;
                a = b;
                b = c;
            }

            var sum = new char[a.Length + 1];
            bool carry = false;

            for (int i = a.Length - 1, j = b.Length - 1, k = sum.Length - 1; i >= 0; i--, j--, k--)
            {
                char x = a[i];
                char y = j >= 0 ? b[j] : '0';

                if (carry)
                {
                    sum[k] = x == y ? '1' : '0';
                    carry = x == '1' || y == '1';
                }
                else
                {
                    sum[k] = x == y ? '0' : '1';
                    carry = x == '1' && y == '1';
                }
            }

            if (carry)
            {
                sum[0] = '1';
                return new string(sum);
            }

            return new string(sum, 1, sum.Length - 1);
        }
        public static string BinaryToHex(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... Will throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            string h0 = "01100111010001010010001100000001";
            string h1 = "11101111110011011010101110001001";
            string h2 = "10011000101110101101110011111110";
            string h3 = "00010000001100100101010001110110";
            string h4 = "11000011110100101110000111110000";
            string message = null;
            string append = null;
            string temp = null;
            string[] splitted = null;
            string A = null;
            string B = null;
            string C = null;
            string D = null;
            string E = null;
            List<string> words = new string[] {}.ToList();
            Console.WriteLine("Please Enter Your Message:");
            message = Console.ReadLine();
            //Converting Each Character --> ASCII --> Binary
            foreach (char c in message)
            {
                append += Convert.ToString(c, 2).PadLeft(8, '0');
            }
            //null = 48 Bits,we need to store 48 bits Binary Here
            temp = Convert.ToString(append.Length, 2).PadLeft(8,'0');
            for (int i =(64-temp.Length);i>0;i--) //64-4 = 60
            {
                temp = "0" + temp;
            }
            //48 Bits + 1 = 49 Bits
            append += "1";
            
            for(int i=(448-append.Length);i>0;i--)
            {
                    append += "0";
            }
            //Final 512 Bits Data
            append += temp;
            Console.WriteLine("The String is " + append);
            Console.WriteLine();
            Console.WriteLine("\nThe String Length is " + append.Length);
            //Dividing into 32 Bit Equal Chunks
            splitted =  SplitIntoChunks(append, 32);
            //We Will Convert Our String Array into String List
            int flag = 0;
            foreach(string s in splitted)
            {
                words.Insert(flag,s);
                flag++;
            }
            //Converting 16 Words to 80 Words
            int j = 16;
            while (j <= 79)
            {
                string a = words[j - 3];
                string b = words[j - 8];
                string c = words[j - 14];
                string d = words[j - 16];
                string app = null;
                
                app = calcXor(a, b);
                app = calcXor(app, c);
                app = calcXor(app, d);
                app = leftRotateShift(app, 1);
                words.Insert(j, app);
                j += 1;
            }
            //Just Printing Before Main Loop
            //foreach (string w in words)
            //{
            //    Console.WriteLine(w);
            //}
            //Store A-E from h0 - h4
            A = h0;
            B = h1;
            C = h2;
            D = h3;
            E = h4;

            //Main Loop
            int m = 0;
            string k = null;
            string F = null;
            string x = null;
            string y = null;
            string z = null;
            string maintemp = null;
            int len = 0;
            while(m < 80)
            {
                //FUNCTION 1
                if(m >= 0 && m <= 19)
                {
                    x = calcAnd(B,C);
                    y = calcAnd(calcNOT(B), D);
                    F = calcOR(x, y);
                    k = "01011010100000100111100110011001";
                }
                //FUNCTION 2
                else if(m >= 20 && m <= 39)
                {
                    x = calcXor(B, C); //I am Not Sure Here As we may need to Pad if something Goes Wrong in Case
                    y = calcXor(x, D);
                    F = y;
                    k = "01101110110110011110101110100001";
                }
                //FUNCTION 3
                else if(m >= 40 && m <= 59)
                {
                    x = calcAnd(B,C);
                    y = calcAnd(B,D);
                    z = calcAnd(C,D);
                    x = calcOR(x, y);
                    F = calcOR(x, z);
                    k = "10001111000110111011110011011100";
                }
                //FUNCTION 4
                else if (m >= 60 && m <= 79)
                {
                    x = calcXor(B, C); //I am Not Sure Here As we may need to Pad if something Goes Wrong in Case
                    y = calcXor(x, D);
                    F = y;
                    k = "11001010011000101100000111010110";
                }
                maintemp = leftRotateShift(A, 5);
                maintemp = calcADD(maintemp, F);
                maintemp = calcADD(maintemp, E);
                maintemp = calcADD(maintemp, k);
                maintemp = calcADD(maintemp, words[m]);
                len = maintemp.Length - 32;
                maintemp = maintemp.Substring(len,32);

                E = D;
                D = C;
                C = leftRotateShift(B, 30);
                B = A;
                A = maintemp;
                m += 1;
            }
            int len1 = 0;
            h0 = calcADD(h0, A);
            len1 = h0.Length - 32;
            h0 = h0.Substring(len1, 32);

            h1 = calcADD(h1, B);
            len1 = h1.Length - 32;
            h1 = h1.Substring(len1,32);

            h2 = calcADD(h2, C);
            len1 = h2.Length - 32;
            h2 = h2.Substring(len1, 32);

            h3 = calcADD(h3, D);
            len1 = h3.Length - 32;
            h3 = h3.Substring(len1, 32);

            h4 = calcADD(h4, E);
            len1 = h4.Length - 32;
            h4 = h4.Substring(len1, 32);
            
            //H0 to H4 --- BINARY TO HEX
            h0 = BinaryToHex(h0);
            h1 = BinaryToHex(h1);
            h2 = BinaryToHex(h2);
            h3 = BinaryToHex(h3);
            h4 = BinaryToHex(h4);
            string final = h0+h1+h2+h3+h4;
            Console.WriteLine("The SHA-1 Hash is : " +final);
            Console.ReadLine();
            //TRASH CHUNKS ===========================================================================================

            //Testing for Binary ADDITION
            //string ax = "00110001000100010000101101110100";
            //string fx = "10001011110000011101111100100001";
            //string ex = "11101001001001111110100110101011";
            //string kx = "11001010011000101100000111010110";
            //string word79 = "10110111011010010100111100111110";
            //string ans = null;
            //ans = calcADD(ax, fx);
            //ans = calcADD(ans, ex);
            //ans = calcADD(ans, kx);
            //ans = calcADD(ans, word79);
            //int n = ans.Length - 32;
            //ans = ans.Substring(n, 32);
            //Console.WriteLine("The Answer is: " + ans + " And its Length is : " + ans.Length);

            //Testing AREA 03
            //B = "11101111110011011010101110001001";
            //C = "10011000101110101101110011111110";
            //D = "00010000001100100101010001110110";
            //string ans = null;
            //string ans1 = null;
            //ans = calcAnd(B, C);
            //ans1 = calcAnd((calcNOT(B)), D);
            //ans = calcOR(ans, ans1);
            //Console.WriteLine("Testing Is succesfull:" + ans);
            ////First We Check for Logical AND OR NOT
            //string monish = "11101111110011011010101110001001";
            //string soni = "00010000001100100101010001110110";
            //string ans = calcNOT(monish);
            //Console.WriteLine("The Logical NOT is: " + ans);
            //string aa = "01000001001000000101010001100101";
            //string bb = "01110011011101001000000000000000";
            //string f = calcXor(aa, bb);

            //int x = 0;
            //int y = 0;
            //w = Convert.ToInt32(a, 2) ^ Convert.ToInt32(b, 2); //XOR of i-3 and i-8
            //app = (IntToBinaryString(w)).PadLeft(32, '0'); //Result 1
            //x = Convert.ToInt32(app, 2) ^ Convert.ToInt32(c, 2); //XOR of result 1 & i-14
            //app = (IntToBinaryString(x)).PadLeft(32, '0'); //Result 2
            //y = Convert.ToInt32(app, 2) ^ Convert.ToInt32(d, 2); //XOR of Result 2 & i-16
            //app = (IntToBinaryString(y)).PadLeft(32, '0'); //Result 3
            //Console.WriteLine(app);
            //this one to XOR two strings binary and store into int
            //temp2 = Convert.ToInt32(splitted[0], 2) ^ Convert.ToInt32(splitted[1], 2);
            //This one to Convert int to Binary
            //s1 = IntToBinaryString(temp2);
            //This one to Add Padding
            //s1 = s1.PadLeft(32, '0');
            //int w = 0;
            //w = (int)(((Convert.ToInt64(a, 2) ^ Convert.ToInt64(b, 2)) ^ Convert.ToInt64(c, 2)) ^ Convert.ToInt64(d, 2));
            //app = (IntToBinaryString(w)).PadLeft(32, '0');
            //app = leftRotateShift(app, 1);


        }
    }
}
