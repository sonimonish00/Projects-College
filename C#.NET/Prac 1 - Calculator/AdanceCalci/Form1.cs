using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdanceCalci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double total1 = 0;
        //double total2 = 0;
        string theOperator;

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn2.Text;
        }

        
        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn3.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn0.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn4.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn9.Text;
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn8.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn7.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length-1, 1);
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox.Text);
            theOperator = "+";
            //YourString = YourString.Remove(YourString.Length - 1);
            textBox.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            double num2;
            double answer;
            
            num2 = double.Parse(textBox.Text);
            //num2 = double.Parse(textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1));

            switch (theOperator)
            {
                case "+":
                    answer = total1 + num2;
                    textBox.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "-":
                    answer = total1 - num2;
                    textBox.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "*":
                    answer = total1 * num2;
                    textBox.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "/":
                    answer = total1 / num2;
                    textBox.Text = answer.ToString();
                    total1 = 0;
                    break;
                default:
                    answer = 0;
                    break;
            }

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btndot.Text;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox.Text); //This is not Plus its a Concantenation of Previous Value so that >= 2 Numbers Could be Taken
            theOperator = "-";
            textBox.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox.Text);
            theOperator = "*";
            textBox.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(textBox.Text);
            theOperator = "/";
            textBox.Clear();
        }
    }
}
