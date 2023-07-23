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
using System.Security.Cryptography;


namespace Admin_Panel
{
    public partial class First_Time_Admin : MetroForm
    {
        string localIP=null;
        MySqlConnection conn;
        MD5 md5Hash = MD5.Create();
        public First_Time_Admin(string ip)
        {
            InitializeComponent();
            localIP = ip;
            if (localIP == null)
            {
                Connect_with_PI pi = new Connect_with_PI();
                localIP = pi.getip();
            }
        }

        private void First_Time_Admin_Load(object sender, EventArgs e)
        {
            string str = "server=" + localIP + ";user id=root;password=ingressems;database=rfid";
            //Password=12345 for RaspberrypI TIME
            conn = new MySqlConnection(str);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtbox_FirstTIme_Email.Text != null && metroTextBox1.Text != null)
                {
                    conn.Open();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO admin(emailid,password) VALUES(@email, @pass)";
                    comm.Parameters.AddWithValue("@email", Txtbox_FirstTIme_Email.Text);
                    comm.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(metroTextBox1.Text)));
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Now You Are Admin Officially !!");
                    conn.Close();

                    this.Hide();
                    Login obj = new Login(localIP);
                    //Problem Could Arrive Here as it not certain that which localIP Would be Passed Up Here.
                    obj.Closed += (s, args) => this.Close();
                    obj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("FIELDS CANT BE EMPTY!!");
                    conn.Close();
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

        }

        private void First_Time_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
            Environment.Exit(1);
        }
    }
}
