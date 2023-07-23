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
using System.Configuration;
namespace Finance_Management_System
{
    public partial class Finance_Login : MetroForm
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newcon"].ConnectionString);
        public Finance_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Frogot_admin_MouseHover(object sender, EventArgs e)
        {
            lbl_Frogot_admin.ForeColor = Color.DarkMagenta;
            //May be Will not work as it metroLabel
        }

        private void lbl_Frogot_admin_Click(object sender, EventArgs e)
        {
            Frogot_Pass obj = new Frogot_Pass();
            obj.ShowDialog();
        }

        private void mtr_Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtr_txtbox_User.Text != null && mtr_TxtBox_Pass.Text != null)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from [Admin] where adminid=@name and password=@pass", conn);
                    cmd.Parameters.AddWithValue("@name", mtr_txtbox_User.Text);
                    cmd.Parameters.AddWithValue("@pass", mtr_TxtBox_Pass.Text);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        MessageBox.Show("Succesful Login!! Welcome Sunil Joshi");
                        this.Hide();
                        Admin_Dashboard obj = new Admin_Dashboard();
                        obj.Closed += (s, args) => this.Close();
                        obj.Show();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login!! Try Again");
                        conn.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }
    }
}
