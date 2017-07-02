using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration.Install;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
namespace User_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
        MD5 md5Hash = MD5.Create();
        Login obj_at_AdminLogin = new Login();
        private void btnLogout_Admin_Click(object sender, EventArgs e)
        {
            this.Close();
            obj_at_AdminLogin.Show();
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            obj_at_AdminLogin.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from [loginuser] where username=@user", conn);
                cmd.Parameters.AddWithValue("user", txtboxUserDelete.Text);
                int result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    MessageBox.Show("User Deleted Sucessfully");
                }
                else
                {
                    MessageBox.Show("Invalid Username");

                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input or User Does not Exsist");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [loginuser] SET password=@pass where username=@user", conn);
                cmd.Parameters.AddWithValue("user", txtBoxUpdateUser.Text);
                cmd.Parameters.AddWithValue("pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtBoxUpdatePass.Text)));

                int result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    MessageBox.Show("Password Updated Sucessfully");
                }
                else
                {
                    MessageBox.Show("Invalid Username");
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input or User Does not Exsist");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                //SqlCommand cmd = new SqlCommand("select * from student", cnn);
                SqlCommand cmd = new SqlCommand("insert into [loginuser] (username,password,fullname,address,sq,sa) values (@user,@pass,@full,@add,@sq,@sa)", conn);

                cmd.Parameters.AddWithValue("user", txtBox_signup_username.Text);
                cmd.Parameters.AddWithValue("pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtBox_signup_pass.Text)));
                cmd.Parameters.AddWithValue("full", txtBox_signup_fullname.Text);
                cmd.Parameters.AddWithValue("add", txtBox_signup_Add.Text);
                cmd.Parameters.AddWithValue("sq", txtBox_signup_SQ.Text);
                cmd.Parameters.AddWithValue("sa", txtBox_signup_SA.Text);
                

                MessageBox.Show("New User Added Sucessfully");
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input or Username Already Exsist");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
