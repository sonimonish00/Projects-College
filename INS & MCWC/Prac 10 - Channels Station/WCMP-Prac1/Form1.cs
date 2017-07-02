using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCMP_Prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int stnnum = 1;
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Btn_Station_1.BackColor = Color.Red;
            string trim = Btn_Station_1.Text.ToString().Substring(0, Btn_Station_1.Text.ToString().Length - 1);
            string i = Btn_Station_1.Text.ToString().Substring(Btn_Station_1.Text.ToString().Length - 1); ;
            txtBox_Line.Text += "-" + i;
            Btn_Station_1.Text = trim;
            timer417.Enabled = true;
            
        }

        private void timer417_Tick(object sender, EventArgs e)
        {
            string name = "Btn_Station_" + stnnum.ToString();
            Button btn = this.Controls.Find(name, true).FirstOrDefault() as Button;
            btn.BackColor = Color.Orange;
            stnnum++;
            timer10.Enabled = true;
            timer417.Enabled = false;
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (stnnum == 13)
            {
                stnnum = 1;

             
            }
            string name = "Btn_Station_" + stnnum.ToString();
            Button btn = this.Controls.Find(name, true).FirstOrDefault() as Button;
            btn.BackColor = Color.Red;
            string trim = btn.Text.ToString().Substring(0,btn.Text.ToString().Length-1);
            string i= btn.Text.ToString().Substring(btn.Text.ToString().Length - 1); ;
            txtBox_Line.Text += "-" + i;
            btn.Text = trim;
            timer10.Enabled = false;
            timer417.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
