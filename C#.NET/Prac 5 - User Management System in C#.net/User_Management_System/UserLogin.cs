using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration.Install;
using System.Configuration;
using System.Security.Cryptography;
namespace User_Management_System
{
    public partial class UserLogin : Form
    {
        public UserLogin(String uname) //Taking From Login Page
        {
            InitializeComponent();
            label7.Text = uname;
            txtBoxUpdateUser.Text = uname;

        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
        MD5 md5Hash = MD5.Create();
        Login obj_at_UserLogin = new Login();
        private void btnLogout_User_Click(object sender, EventArgs e)
        {
            this.Close();
            obj_at_UserLogin.Show();

        }

        private void UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            obj_at_UserLogin.Show();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr = null;
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from [loginuser] where username=@username ;", conn);
                cmd.Parameters.AddWithValue("username", label7.Text);
                rdr = cmd.ExecuteReader();
                
                if (rdr.Read())
                {
                    
                   // label8.Text = rdr[1].ToString(); //Password

                    label9.Text = rdr[2].ToString();

                    label10.Text = rdr[3].ToString();

                    label11.Text = rdr[4].ToString();

                    label12.Text = rdr[5].ToString();

                    byte[] img = (byte[]) (rdr[6]);
                    if (img == null)
                    {
                        pictureBox_user.Image = null;
                    
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox_user.Image = Image.FromStream(ms);

                    } 

                }
                rdr.Close();
                conn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("OOPS SOME ERROR");
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update [loginuser] set password=@pass , fullname=@full , address=@add , sq=@sq , sa=@sa where username=@user", conn);
                cmd.Parameters.AddWithValue("pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtBoxUpdatePass.Text)));
                cmd.Parameters.AddWithValue("full", txtBoxUpdateFullname.Text);
                cmd.Parameters.AddWithValue("add", txtBoxUpdateAdd.Text);
                cmd.Parameters.AddWithValue("sq", txtBoxUpdateSQ.Text);
                cmd.Parameters.AddWithValue("sa", txtBoxUpdateSA.Text);
                cmd.Parameters.AddWithValue("user", txtBoxUpdateUser.Text);

                int result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    MessageBox.Show("Profile Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Invalid Username ");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
