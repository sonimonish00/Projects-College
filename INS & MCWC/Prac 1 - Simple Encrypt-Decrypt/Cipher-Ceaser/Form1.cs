using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher_Ceaser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Logic For Program
            //ENCRYPTION

            //A-> 65(ASCII)-> + Key(ex - 3)-> 68(D) - 1(Static)-> 67-> 76(Rev.) -> + Key(3)->79(Cipher Text)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plaintext = textBox1.Text;
            int key = int.Parse(textBox2.Text);
            string finalvalue = null;
            Reverse obj = new Reverse();
            byte[] ascii = Encoding.ASCII.GetBytes(plaintext);
            foreach (Byte b in ascii)
            {
                int c = 0;
                c = b + key;
                c = c - 1; // My Static Value 1 which i Provide Implicitly
                c = obj.rev(c);
                c += key;
                finalvalue = finalvalue + c.ToString() + "*";
            }
           
            textBox3.Text = finalvalue;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Reverse obj1 = new Reverse();
            string cipher = textBox6.Text;
            int Dkey = int.Parse(textBox5.Text);
            string final = null;
            string[] words = cipher.Split('*');
            //var arr = Regex.Split(cipher, "(?<=.)(?=.)");
            //foreach (var value in arr)
            //{
            //    MessageBox.Show(value.ToString()); //Separates 7989 -> 7 9  8 9 
            //}
            var remStrings = words.Take(words.Length - 1); //We got 7989
            foreach (string word in remStrings)
            {
                //word = 79 : String should be Converted into int 
                int n = int.Parse(word);
                //step 1. : 79-Key = 79-3 = 76
                n = n - Dkey;
                //Step 2. : 76 -> 67
                n = obj1.rev(n);
                //Step 3. : Static + 1 --> 67+1 = 68
                n += 1;
                //Step 4. : 68-key => 68-3 = 65
                n = n - Dkey;
                //Step 5. : 65 to ASCII
                int unicode = n;
                char character = (char)unicode;
                final += character.ToString();
            }
            textBox4.Text = final.ToString();

        }
    }
}
