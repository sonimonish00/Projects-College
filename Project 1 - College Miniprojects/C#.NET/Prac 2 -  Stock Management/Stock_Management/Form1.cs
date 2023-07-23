using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void onlynumwithsinglepoint(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlynumwithsinglepoint(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Invalid Entry !!");
            }
            else {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1)
            {
                int i = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(i);
                listBox2.Items.RemoveAt(i);
            }
            else 
            {
                int count = listBox2.SelectedIndices.Count; //Price
                for (int k = count - 1; k >= 0; k--)
                {
                    int temp = listBox2.SelectedIndices[k];
                    listBox1.Items.RemoveAt(temp);
                    listBox2.Items.RemoveAt(temp);
                }
            
                int count1 = listBox1.SelectedIndices.Count; //Name
                for (int j = count1 - 1; j >= 0; j--)
                {
                    int temp1 = listBox1.SelectedIndices[j];
                    listBox1.Items.RemoveAt(temp1);
                    listBox2.Items.RemoveAt(temp1);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
