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
using System.Net.Mail;
using System.Security.Cryptography;
namespace Admin_Panel
{
    public partial class Login : MetroForm
    {
    
        string localIP=null;
        MySqlConnection conn;
        MD5 md5Hash = MD5.Create();
        public Login(string ip)
        {
            InitializeComponent();
            localIP = ip;
            
            if (localIP == null)
            {
                Connect_with_PI pi = new Connect_with_PI();
                localIP = pi.getip();
                
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
            string str = "server="+localIP+ ";user id=root;password=ingressems;database=rfid";
            //Password=12345 for RaspberrypI TIME
            conn = new MySqlConnection(str);
            
            try
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("select count(*) from admin", conn);
                int result1 = 0;
                result1 = Convert.ToInt32(cmd1.ExecuteScalar());
                if (result1 == 0) //Means If No Admin is There in DB. This is the First Day of Admin
                {
                    this.Hide();
                    First_Time_Admin obj = new First_Time_Admin(localIP);
                    obj.Closed += (s, args) => this.Close();
                    obj.ShowDialog();
                }
                else {
                    TabControl_Login.SelectedTab = TabPage_Login;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally {
                conn.Close();
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
            Environment.Exit(1);
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_Email.Text != null && txtbox_Password.Text != null)
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from admin where emailid=@name and password=@pass", conn);
                    cmd.Parameters.AddWithValue("@name", txtbox_Email.Text);
                    cmd.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtbox_Password.Text)));
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        MessageBox.Show("Succesful Login!! Welcome Admin");
                        this.Hide();
                        Main_Window obj = new Main_Window(localIP);
                        obj.Closed += (s, args) => this.Close();
                        obj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login!! Try Again");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally {
                conn.Close();
            }
        }
        private void SETOTP(String otp_number)
        {

            //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=1234;database=student");
            conn.Close();
            conn.Open();

            String query = "UPDATE admin SET otp = @otp WHERE emailid=@name;";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@otp", otp_number);
            command.Parameters.AddWithValue("@name", txtbox_Email_Forgot.Text);
            command.ExecuteNonQuery();
            conn.Close();
        }
        private void Btn_OTP_OK_Click(object sender, EventArgs e)
        {
            String Name1 = txtbox_Email_Forgot.Text;
            String No1;
            //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=1234;database=student");
            conn.Open();

            String query = "select * from admin where emailid=@email";
            MySqlCommand command = new MySqlCommand(query, conn);
           
            command.Parameters.AddWithValue("@email", Name1);
            //command.ExecuteNonQuery();
            MySqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows==true)
            {
                Random rnd = new Random();
                int otp = rnd.Next(1000, 10000);
                SETOTP(otp.ToString());
                
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("vandanshah41@gmail.com");
                mail.To.Add(txtbox_Email_Forgot.Text);
                mail.Subject = "Forgoten Password";
                mail.Body = "This is your automatically generated One Time Password please enter this OTP carefully ---> " + otp;
                SmtpServer.Port = 587;
                
                SmtpServer.Credentials = new System.Net.NetworkCredential("vandanshah41@gmail.com", "vandan@255130");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("OTP is sent you on given Email-Id....");
                OTPgroup.Visible = true;                
                txtbox_Email_Forgot.ReadOnly = true;
                Btn_OTP_OK.Enabled = false;
            }
            else
            {
                MessageBox.Show("Could not Send OTP Due to Invalid Email Address!!");
            }
        }

        private void btncheckotp_Click(object sender, EventArgs e)
        {
            
            conn.Open();

            String query1 = "select * from admin where emailid=@Name AND otp=@otp";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@name", txtbox_Email_Forgot.Text);
            command1.Parameters.AddWithValue("@otp", txtBox_OTP.Text);
            //command.ExecuteNonQuery();
            MySqlDataReader dr = command1.ExecuteReader();
            if (dr.HasRows)
            {
                newgroup.Visible = true;
            }
            else
            {
                MessageBox.Show("You Have entered wrong OTP please enter carefully...!!");
            }
        }

        private void Btn_Forgot_Reset_Pass_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();

            String query = "UPDATE admin SET password = @pass WHERE emailid=@name;";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(TxtBox_NEw_Pass.Text)));
            command.Parameters.AddWithValue("@name", txtbox_Email_Forgot.Text);
            int i=command.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("Password reseted sucessfully..!!");
                TabControl_Login.SelectTab(0);
            }
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_Email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_Password_Click(object sender, EventArgs e)
        {

        }
    }
}
