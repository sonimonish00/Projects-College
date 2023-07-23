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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        MD5 md5Hash = MD5.Create();
     
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        string imglocation="";
        private void btn_singup_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
            try
            {

                if (txtBox_signup_username.Text != null && txtBox_signup_fullname.Text != null && txtBox_signup_pass.Text != null && txtBox_signup_retypePass != null && (txtBox_signup_pass == txtBox_signup_retypePass) && txtBox_signup_Add != null && txtBox_signup_SQ != null && txtBox_signup_SA != null)
                {
                    MessageBox.Show("You have Validated All of the Criterias Above and now You will be Signed Up ");

                }

                byte[] img = null;
                FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                
                conn.Open();
SqlCommand cmd = new SqlCommand("insert into [loginuser] (username,password,fullname,address,sq,sa,image) values (@username,@pass,@full,@add,@sq,@sa,@img)",conn);
                cmd.Parameters.AddWithValue("username", txtBox_signup_username.Text);
                cmd.Parameters.AddWithValue("pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtBox_signup_pass.Text)));
                cmd.Parameters.AddWithValue("full", txtBox_signup_fullname.Text);
                cmd.Parameters.AddWithValue("add", txtBox_signup_Add.Text);
                cmd.Parameters.AddWithValue("sq", txtBox_signup_SQ.Text);
                cmd.Parameters.AddWithValue("sa", txtBox_signup_SA.Text);
                cmd.Parameters.AddWithValue("img",img);
                MessageBox.Show("Account Created Sucessfully");
                cmd.ExecuteReader();
                conn.Close();
                this.Close();
                //AdminLogin admin_login_obj = new AdminLogin();
                //admin_login_obj.ShowDialog();


            } //End of Try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }            
        }

        private void Btn_Signup_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg) |*.jpg |GIF Files(*.gif) |*.gif |All Files (*.*)|*.*";
                dlg.Title = "Select Your Profile Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imglocation = dlg.FileName.ToString();
                    pictureBox_Signup.ImageLocation = imglocation;
                }
                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
