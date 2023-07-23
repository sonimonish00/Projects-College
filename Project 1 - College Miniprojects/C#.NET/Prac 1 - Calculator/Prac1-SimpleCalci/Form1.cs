using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac1_SimpleCalci
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {

        }

        private void Txtbox1_TextChanged(object sender, EventArgs e)
        {
            //double i;
            //i = float.Parse(Txtbox1.Text);

        }

        private void Txtbox2_TextChanged(object sender, EventArgs e)
        {
            //double j;
            //j = float.Parse(Txtbox2.Text);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Txtbox1.Text);
            double b = Convert.ToDouble(Txtbox2.Text);
            textBoxResult.Text = (a + b).ToString();
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Txtbox1.Text);
            double b = Convert.ToDouble(Txtbox2.Text);
            textBoxResult.Text = (a - b).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Txtbox1.Text);
            double b = Convert.ToDouble(Txtbox2.Text);
            textBoxResult.Text = (a * b).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            
                double a = Convert.ToDouble(Txtbox1.Text);
                double b = Convert.ToDouble(Txtbox2.Text);
            try
            {
                textBoxResult.Text = (a / b).ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot Divide By Zero !!");
            }
        }
        
    }
}
