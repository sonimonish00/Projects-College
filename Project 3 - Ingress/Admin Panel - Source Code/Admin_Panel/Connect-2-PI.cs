using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Reflection;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net;
using System.Net.Sockets;

namespace Admin_Panel
{
    public partial class Connect_2_PI : MetroForm
    {
        private MySqlConnection conn;
        public Connect_2_PI()
        {
            InitializeComponent();
        }

        private void Connect_2_PI_Load(object sender, EventArgs e)
        {
            //Nothing Right Now
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {

                string str = "server=" +txtBox_IP.Text + ";user id=root;password=ingressems;database=rfid";
                
                //server=localhost;user id=root;persistsecurityinfo=True;database=rfid

                //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;

                //Password=12345 for RaspberrypI TIME
                conn = new MySqlConnection(str);
                conn.Open();
                conn.Close();
                MessageBox.Show("Connected succesfully with server");

                //this.Hide();
                //Login obj = new Login(txtBox_IP.Text);
                //obj.Closed += (s, args) => this.Close();
                //obj.Show();
                this.Hide();
                Login obj = new Login(txtBox_IP.Text);
                obj.ShowDialog();
                //this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something is wrong please enter IP address carefully ==> "+ex.Message);
                
            }
        }

        private void Connect_2_PI_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
            Environment.Exit(1);
        }
    }
}
