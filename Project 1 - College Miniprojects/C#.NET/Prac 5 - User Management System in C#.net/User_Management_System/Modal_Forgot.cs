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
    public partial class Modal_Forgot : Form
    {
        public Modal_Forgot()
        {
            InitializeComponent();
        }
        MD5 md5Hash = MD5.Create();
        private void lbl_SecretA_Click(object sender, EventArgs e)
        {
            //Nothing
        }

        private void btn_forgot_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
        SqlDataReader rdr = null;

        private void btn_Go_Forgot_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "select * from [loginuser] where username=@username";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("username", txtBox_Forgot_Password.Text);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            
            txtBox_SecretQ.Text=rdr[4].ToString();
            conn.Close();

        }

        private void btn_Forgot_OK_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "select * from [loginuser] where username=@username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", txtBox_Forgot_Password.Text);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            if (txtBox_SecretA.Text == rdr[5].ToString())
            {
                txtboxResetPass.Enabled = true;
            }
            conn.Close();
        }

        private void btnFinalOK_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update [loginuser] set password=@pass where username=@user", conn);
                cmd.Parameters.AddWithValue("pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtboxResetPass.Text)));
                //
                cmd.Parameters.AddWithValue("user", txtBox_Forgot_Password.Text);
                int result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    MessageBox.Show("Password Reset Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not Reset Password ");
                }
                
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
