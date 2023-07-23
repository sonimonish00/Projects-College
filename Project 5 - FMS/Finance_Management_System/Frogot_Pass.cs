using MetroFramework.Forms;
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
namespace Finance_Management_System
{
    public partial class Frogot_Pass : MetroForm
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
        public Frogot_Pass()
        {
            InitializeComponent();
        }

        private void Frogot_Pass_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Here it will Check the Pincode with DB of Admin Table and if Correctly Entered So Will Accept the New
            //Password and Update it in Database and Return to the Original Form of Login
            try
            {
                if (metroTextBox_Username.Text != null && metroTextBox_Pincode.Text != null && metroTextBox_NewPass.Text!=null)
                {
                    SqlDataReader rdr = null;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from [Admin] where Adminid=@admin and Pincode=@pin;", conn);
                    cmd.Parameters.AddWithValue("admin", metroTextBox_Username.Text);
                    cmd.Parameters.AddWithValue("pin", metroTextBox_Pincode.Text);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        SqlCommand cmd1 = new SqlCommand("UPDATE [Admin] SET password=@pass where Adminid=@admin", conn);
                        cmd1.Parameters.AddWithValue("admin", metroTextBox_Username.Text);
                        cmd1.Parameters.AddWithValue("pass", metroTextBox_NewPass.Text);

                        int result = cmd1.ExecuteNonQuery();
                        if (result != 0)
                        {
                            MessageBox.Show("Password Reset Sucessfully");
                            this.Hide();
                            Finance_Login obj = new Finance_Login();
                            //Very Important Line Below :D :) 
                            obj.Closed += (s, args) => this.Close();
                            obj.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sorry!!Something Went Wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Pincode !! Try Again");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
