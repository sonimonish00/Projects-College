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
using System.Security.Cryptography;
namespace User_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
        MD5 md5Hash = MD5.Create();
        private void label2_Click(object sender, EventArgs e)
        {
            //Nothing
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            { //Intitally When the Form will Load
                
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select count(*) from loginadmin", conn);
                Int32 result1 = 0;
                result1 = (Int32)cmd1.ExecuteScalar();
                if (result1 == 0) //If there is No Admin in Database By Default
                {
                    grpBoxFirstTime.Visible = true;
                    grpBoxLogin.Visible = false;
                    txtboxuser.Enabled = true;
                    txtboxPass.Enabled = true;
                }

                else {
                    //Going to Firs Groupbox - Login
                    grpBoxFirstTime.Visible = false;
                    grpBoxLogin.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void lblGuestLogin_Click(object sender, EventArgs e)
        {
            // To go To Guest Page - Guestuff.cs
            Form1 guest = new Form1();
            guest.ShowDialog();
        }

        private void lblGuestLogin_MouseHover(object sender, EventArgs e)
        {
            lblGuestLogin.ForeColor = Color.GhostWhite;
        }

        private void lblGuestLogin_MouseLeave(object sender, EventArgs e)
        {
            lblGuestLogin.ForeColor = Color.Black;
        }

        private void lblForgotPassword_MouseHover(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.BlanchedAlmond;
        }

        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.Black;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            Modal_Forgot modal_forgot_obj = new Modal_Forgot();
            modal_forgot_obj.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radioBtnAdmin.Checked && txtboxUsername.Text!=null && txtboxPassword.Text!=null)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from loginadmin where adminid=@name and password=@pass", conn);
                    cmd.Parameters.AddWithValue("@name", txtboxUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtboxPassword.Text)));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Succesful");
                        this.Hide();
                        AdminLogin admin_login_obj = new AdminLogin();
                        admin_login_obj.ShowDialog();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login of ADMIN please Enter Correct username and password");
                        conn.Close();
                    }
                } //End of Try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }

                finally {
                    conn.Close();
                }
            }
            if (radioBtnGuest.Checked && txtboxUsername.Text != null && txtboxPassword.Text != null)
            {
                try
                {
                    String uname = txtboxUsername.Text;
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from loginuser where username=@name and password=@pass", conn);
                    cmd.Parameters.AddWithValue("@name", txtboxUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtboxPassword.Text)));
                    //                 
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Succesful");
                        this.Hide();
                        UserLogin user_login_obj = new UserLogin(uname);
                        user_login_obj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login of USER please Enter Correct username and password");
                    }
                } //End of Try
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signupObj = new SignUp();
            signupObj.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into [loginadmin] (adminid,password) values (@username,@pass)", conn);
                cmd.Parameters.AddWithValue("username", txtboxuser.Text);
                cmd.Parameters.AddWithValue("pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtboxPass.Text)));
                cmd.ExecuteReader();
                MessageBox.Show("Account Created Sucessfully");
                //Now GroupBox Login Would be Activated
                grpBoxLogin.Visible = true;
                grpBoxFirstTime.Visible = false;

            } //End of Try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
