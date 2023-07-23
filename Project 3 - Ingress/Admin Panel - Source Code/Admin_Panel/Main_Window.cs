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
using System.Diagnostics;
using System.Security.Cryptography;

namespace Admin_Panel
{
    public partial class Main_Window : MetroForm
    {
        string localIP = null;
        MySqlConnection conn;
        MD5 md5Hash = MD5.Create();
        public Main_Window(string ip)
        {
            InitializeComponent();

            timer.Start();
            TabControl_Main.SelectedTab = TabPage_Operations;
            TabControl_Operation_All_Operation.SelectedTab = TabPage_Register;

            localIP = ip;
            if (localIP == null)
            {
                Connect_with_PI pi = new Connect_with_PI();
                localIP = pi.getip();
            }
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            string str = "server=" + localIP + ";user id=root;password=ingressems;database=rfid";
            //Password=12345 for RaspberrypI TIME
            conn = new MySqlConnection(str);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.LabelTimer.Text = dateTime.ToString();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login(localIP);
            obj.Closed += (s, args) => this.Close();
            obj.ShowDialog();
        }
        
        private void pictureBox_Register_Click(object sender, EventArgs e)
        {
            TabControl_Operation_All_Operation.SelectedTab = TabPage_Register;
        }

        private void pictureBox_Remove_Click(object sender, EventArgs e)
        {
            TabControl_Operation_All_Operation.SelectedTab = TabPage_Remove;
        }

        private void pictureBox_UpdateInfo_Click(object sender, EventArgs e)
        {
            TabControl_Operation_All_Operation.SelectedTab = TabPage_Update;
        }

        private void pictureBox_Forgot_Pass_Click(object sender, EventArgs e)
        {
            TabControl_Operation_All_Operation.SelectedTab = TabPage_Forgot;
            
        }

        private void pictureBox_Admin_Change_Click(object sender, EventArgs e)
        {
            TabControl_Operation_All_Operation.SelectedTab = TabPage_ChangeAdmin;
            
        }

        private void TxtBox_Searchbox_Del_TextChanged(object sender, EventArgs e)
        {
            try
            {
                

                conn.Open();
                if (ComboBox_Remove.Text == "Enrollment No")
                {
                    //For Student Searching
                    string query = @"SELECT * FROM student_info WHERE enrol LIKE @tags";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", TxtBox_Searchbox_Del.Text + "%"); //"%" +Search_txtbox.Text+ "%"
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Remove.DataSource = dt;
                }
                else if (ComboBox_Remove.Text == "UniqueID(For Guest)")
                {
                    //For Guest Searching
                    string query = @"SELECT * FROM guest_user WHERE enrol LIKE @tags";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", TxtBox_Searchbox_Del.Text + "%"); //"%" +Search_txtbox.Text+ "%"
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Remove.DataSource = dt;
                }
                else if (ComboBox_Remove.Text == "PC No")
                {
                    //For PC number Searching
                    string query = @"SELECT * FROM not_use_pc WHERE pc_number LIKE @tags";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", TxtBox_Searchbox_Del.Text + "%"); //"%" +Search_txtbox.Text+ "%"
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Remove.DataSource = dt;
                }
                else {
                    MessageBox.Show("Sorry No Match Found!!");
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

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Main_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
            Environment.Exit(1);
        }

        private void Btn_AddPC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO not_use_pc (mac_id, ip_address, pc_number) VALUES (@mac, @ip, @pc);";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@mac", txtbox_MacID_PC.Text);
                command.Parameters.AddWithValue("@ip", txtBox_IPAddress_Add_PC.Text);
                command.Parameters.AddWithValue("@pc", txtbox_PCNO_ADD_PC.Text);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Successfully Added New PC");
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

        private void txtbox_Add_new_Student_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO student_info (code,enrol,name,branch,password,mobile,time_slot) VALUES (@rfid, @enrol, @name,@branch,@pass,@mob,@time);";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@rfid", txtbox_RFID_Code.Text);
                command.Parameters.AddWithValue("@enrol", txtbox_Enrollment_No.Text);
                command.Parameters.AddWithValue("@name", txtbox_Stu_name.Text);
                command.Parameters.AddWithValue("@branch", txtbox_Stu_Branch.Text);
                command.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtbox_Stu_Pass.Text)));
                command.Parameters.AddWithValue("@mob", txtbox_Stu_Mobile.Text);
                command.Parameters.AddWithValue("@time", txtbox_Stu_Time.Text);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Successfully Added New Student");
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

        private void txtbox_Add_New_Guest_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "INSERT INTO guest_user (enrol,name,branch,password,mobile,time_slot) VALUES (@enrol, @name,@branch,@pass,@mob,@time);";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@enrol", txtbox_Guest_Enroll.Text);
                command.Parameters.AddWithValue("@name", txtbox_Guestname.Text);
                command.Parameters.AddWithValue("@branch", txtbox_Guest_Branch.Text);
                command.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtbox_Guest_Password.Text)));
                command.Parameters.AddWithValue("@mob", txtbox_Guest_Mobile.Text);
                command.Parameters.AddWithValue("@time", txtbox_Guest_Time.Text);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Successfully Added New Guest");
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

        
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void txtbox_Search_For_Update_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (Combox_4_Update.Text == "Enrollment No")
                {
                    //For Student Searching
                    string query = @"SELECT * FROM student_info WHERE enrol LIKE @tags";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", txtbox_Search_For_Update.Text + "%"); //"%" +Search_txtbox.Text+ "%"
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Update.DataSource = dt;
                }
                else if(Combox_4_Update.Text == "UniqueID(For Guest)")
                {
                    //For Guest Searching
                    string query = @"SELECT * FROM guest_user WHERE enrol LIKE @tags";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", txtbox_Search_For_Update.Text + "%"); //"%" +Search_txtbox.Text+ "%"
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Update.DataSource = dt;
                }
                else {
                    MessageBox.Show("Sorry No Match Found!!");
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
        Int64 enrollment;
        private void dataGridView_Update_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Update.Rows[e.RowIndex];
                enrollment = Convert.ToInt64(row.Cells["enrol"].Value);
                MySqlDataReader rdr = null;
                MySqlCommand cmd = null;
                MySqlCommand cmd1 = null;
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("select * from student_info where enrol=@enrol;", conn);
                    cmd.Parameters.AddWithValue("enrol", enrollment);
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        Update_txtbox_RFID.Text = rdr[0].ToString();
                        Update_txtbox_Enrol_Student.Text = rdr[1].ToString();
                        Update_txtbox_Sname.Text = rdr[2].ToString();
                        Update_txtbox_SBranch.Text = rdr[3].ToString();
                        Update_txtbox_SMob.Text = rdr[5].ToString();
                        metroTextBox1.Text = rdr[7].ToString();
                    }

                    else
                    {
                        //Closing Previous Open Connection if ANy
                        rdr.Close();
                        cmd1 = new MySqlCommand("select * from guest_user where enrol=@enrol;", conn);
                        cmd1.Parameters.AddWithValue("enrol", enrollment);
                        rdr = cmd1.ExecuteReader();
                        if (rdr.Read())
                        {
                            Update_txtbox_Enrol_Guest.Text = rdr[0].ToString();
                            Update_txtbox_GName.Text = rdr[1].ToString();
                            Update_txtbox_GBranch.Text = rdr[2].ToString();
                            Update_txtbox_GMob.Text = rdr[4].ToString();
                            Update_txtbox_Time.Text = rdr[6].ToString();
                        }
                        rdr.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    rdr.Close();
                    conn.Close();
                }
            }
        }

        private void Btn_Show_Update_Student_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM student_info", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Update.DataSource = dt;
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

        private void Btn_Show_Update_Guest_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM guest_user", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Update.DataSource = dt;
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

        private void Btn_Update_Stu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE student_info SET code = @co, enrol = @en, name = @nm, branch=@br, mobile=@mob,time_slot=@time WHERE enrol=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@co", Update_txtbox_RFID.Text);
                cmd.Parameters.AddWithValue("@en", Update_txtbox_Enrol_Student.Text); //TEST HERE IF CODE DOESNT WORKS UP
                cmd.Parameters.AddWithValue("@nm", Update_txtbox_Sname.Text);
                cmd.Parameters.AddWithValue("@br", Update_txtbox_SBranch.Text);
                cmd.Parameters.AddWithValue("@id", enrollment);
                cmd.Parameters.AddWithValue("@mob", Update_txtbox_SMob.Text);
                cmd.Parameters.AddWithValue("@time", metroTextBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated Student Details");
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

        private void Btn_Update_Guest_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE guest_user SET enrol = @en, name = @nm, branch=@br, mobile=@mob,time_slot=@time WHERE enrol=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@en", Update_txtbox_Enrol_Guest.Text); //TEST HERE IF CODE DOESNT WORKS UP
                cmd.Parameters.AddWithValue("@nm", Update_txtbox_GName.Text);
                cmd.Parameters.AddWithValue("@br", Update_txtbox_GBranch.Text);
                cmd.Parameters.AddWithValue("@id", enrollment);
                cmd.Parameters.AddWithValue("@mob", Update_txtbox_GMob.Text);
                cmd.Parameters.AddWithValue("@time", Update_txtbox_Time.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated Guest User Details");
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
        Int64 pcno;
        private void dataGridView_Remove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Remove.Rows[e.RowIndex];

                try {
                enrollment = Convert.ToInt64(row.Cells["enrol"].Value);
                MessageBox.Show("Showing Enrollment No:"+enrollment);

                }
                catch(Exception) {
                pcno = Convert.ToInt64(row.Cells["pc_number"].Value);
                MessageBox.Show("Showing PC No:" +pcno);
                }
            }
            
        }

        private void RemoveBtn_Show_Student_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM student_info", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Remove.DataSource = dt;
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

        private void RemoveBtn_Guest_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM guest_user", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Remove.DataSource = dt;
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

        private void RemoveBtn_ShowPC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM not_use_pc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Remove.DataSource = dt;
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

       
        private void Btn_Del_Student_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = null;
            
            try
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE from student_info where enrol=@enrol;", conn);
                cmd.Parameters.AddWithValue("@enrol", enrollment);
                int ans = cmd.ExecuteNonQuery();

                if (ans > 0) //Means 1 Rows is Affected
                {
                    MessageBox.Show("Succesfully Deleted the Student having Enrollment No. : " + enrollment);
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

        private void Btn_Del_Guest_User_Click(object sender, EventArgs e)
        {
           
            MySqlCommand cmd1 = null;
            try
            {
                conn.Open();
                cmd1 = new MySqlCommand("DELETE from guest_user where enrol=@enrol;", conn);
                cmd1.Parameters.AddWithValue("@enrol", enrollment);
                int ans1 = cmd1.ExecuteNonQuery();

                if (ans1 > 0) //Means 1 Rows is Affected
                {
                    MessageBox.Show("Succesfully Deleted the Guest User having Enrollment No. : " + enrollment);
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

        private void Btn_Del_PC_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd2 = null;
            try
            {
                conn.Open();
                cmd2 = new MySqlCommand("DELETE from not_use_pc where pc_number=@pc;", conn);
                cmd2.Parameters.AddWithValue("@pc", pcno); //Change Here
                int ans2 = cmd2.ExecuteNonQuery();

                if (ans2 > 0) //Means 1 Rows is Affected
                {
                    MessageBox.Show("Succesfully Deleted the PC having PC Number : " + pcno); //Change here
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

        private void metroButton2_Click(object sender, EventArgs e) //For Student Forgotten Password
        {
            try
            {
                conn.Open();
                string query = @"UPDATE student_info SET password=@pass WHERE enrol=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtBox_Newpass_ForStudorGues.Text)));
                cmd.Parameters.AddWithValue("@id", Txtbox_Enrol_Both.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Reset Student Password Having Enrollment No. : " +Txtbox_Enrol_Both.Text);
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

        private void metroButton1_Click(object sender, EventArgs e) //For guest Forgotten password
        {
            try
            {
                conn.Open();
                string query = @"UPDATE guest_user SET password=@pass WHERE enrol=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtBox_Newpass_ForStudorGues.Text)));
                cmd.Parameters.AddWithValue("@id", Txtbox_Enrol_Both.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Reset Guest User Password Having Unique ID : " +Txtbox_Enrol_Both.Text);
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

        private void Btn_Change_admin_Pass_Click(object sender, EventArgs e)
        {
            try
            {
                    conn.Open();
                    MySqlDataReader rdr = null;
                    MySqlCommand cmd = new MySqlCommand("select * from admin where emailid=@email and password=@pass;", conn);
                    cmd.Parameters.AddWithValue("email", txtbox_admin_Change_EMAILID.Text);
                    cmd.Parameters.AddWithValue("pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtbox_admin_Change_oldPass.Text)));
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        rdr.Close();
                        MySqlCommand cmd1 = new MySqlCommand("UPDATE admin SET password=@pass where emailid=@email;", conn);
                        cmd1.Parameters.AddWithValue("email", txtbox_admin_Change_EMAILID.Text);
                        cmd1.Parameters.AddWithValue("pass", md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtbox_admin_Change_NewPass.Text)));
                    

                        int result = cmd1.ExecuteNonQuery();

                            if (result != 0)
                            {
                                MessageBox.Show("Admin Password Reset Sucessfully");
                            }
                            else
                            {
                                MessageBox.Show("Sorry!!Something Went Wrong");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Wrong password !! Try Again");
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

        private void Btn_Refresh_UsePC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM in_use_pc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_UsedPC.DataSource = dt;
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

        private void Btn_Refresh_UnusePC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM not_use_pc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_UnusedPC.DataSource = dt;
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

        private void txtbox_Search_Logs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (Combobox_Logs.Text == "Enrollment_No")
                {
                    //Do Editing Here
                    string query = @"SELECT * FROM log WHERE enrol LIKE @tags";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("tags", txtbox_Search_Logs.Text + "%"); //"%" +Search_txtbox.Text+ "%"
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Logs.DataSource = dt;
                }
                else {
                    MessageBox.Show("Sorry No Match Found!!");
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
        private void formate(int th, int tm, int ts)
        {
            int s = ts / 60;
            int m = tm / 60;
            if (s >= 1)
            {
                tm += s;
                ts = ts - (s * 60);
            }
            if (m >= 1)
            {
                th += m;
                tm = tm - (m * 60);
            }
            string total = th.ToString() + ":" + tm.ToString() + ":" + ts.ToString();
            Txtbox_display_TimeUsed.Text = total;
        }
        private void dataGridView_Logs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Logs.Rows[e.RowIndex];

                enrollment = Convert.ToInt64(row.Cells["enrol"].Value);
                MessageBox.Show("Selected Enrollment No. is :" +enrollment.ToString());
                MySqlDataReader rdr = null;
                MySqlCommand cmd = null;
                MySqlCommand cmd1 = null;
                try
                {
                    conn.Open();
                   
                    cmd = new MySqlCommand("select * from student_info where enrol=@enrol;", conn);
                    cmd.Parameters.AddWithValue("enrol", enrollment);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {  
                        Txtbox_display_RFID.Text = rdr[0].ToString();
                        Txtbox_display_Enrol.Text = rdr[1].ToString();
                        Txtbox_display_Name.Text = rdr[2].ToString();
                        Txtbox_display_Branch.Text = rdr[3].ToString();
                    }
                    rdr.Close();

                    cmd1 = new MySqlCommand("select * from log where enrol=@enrol;", conn);
                    cmd1.Parameters.AddWithValue("enrol", enrollment);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    int count = dt.Rows.Count;
                    int th = 00;
                    int tm = 00;
                    int ts = 00;
                    for (int i = 0; i < count; i++)
                    {
                        DateTime st = DateTime.Parse(dt.Rows[i][2].ToString());
                        DateTime et = DateTime.Parse(dt.Rows[i][3].ToString());
                        int sh = st.Hour;
                        int sm = st.Minute;
                        int ss = st.Second;

                        int eh = et.Hour;
                        int em = et.Minute;
                        int es = et.Second;

                        th += int.Parse(et.Subtract(st).Duration().ToString("hh"));
                        tm += int.Parse(et.Subtract(st).Duration().ToString("mm"));
                        ts += int.Parse(et.Subtract(st).Duration().ToString("ss"));
                    }
                    formate(th, tm, ts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    rdr.Close();
                    conn.Close();
                }
            }
        }

        private void Btn_Show_Logs_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM log", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_Logs.DataSource = dt;
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

        string ipturnoff;
        string macoff;
        string pcoff;
        private void dataGridView_UsedPC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_UsedPC.Rows[e.RowIndex];
            try
            {
                ipturnoff = Convert.ToString(row.Cells["ip_address"].Value);
                macoff = Convert.ToString(row.Cells["mac_id"].Value);
                pcoff = Convert.ToString(row.Cells["pc_number"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }

        private void Btn_Turnoff_PC_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = null;
            MySqlCommand cmd1 = null;
            try
            {
                //Delete Query from Used PC (in use PC)
                conn.Open();
                cmd = new MySqlCommand("DELETE from in_use_pc where mac_id=@mac;", conn);
                cmd.Parameters.AddWithValue("@mac", macoff);
                cmd.ExecuteNonQuery();

                //if (ans > 0) //Means 1 Rows is Affected
                //{
                //    MessageBox.Show("Succesfully Turned Off PC having MAC ID : " +macoff);
                //}

                //Insert Query into Unused PC (not in use PC)

                String query = "INSERT INTO not_use_pc (mac_id, ip_address, pc_number) VALUES (@mac, @ip, @pc);";
                cmd1 = new MySqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@mac", macoff);
                cmd1.Parameters.AddWithValue("@ip", ipturnoff);
                cmd1.Parameters.AddWithValue("@pc", pcoff);
                int i = cmd1.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Successfully Turned Off PC");
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

        private void Btn_Turnon_PC_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
