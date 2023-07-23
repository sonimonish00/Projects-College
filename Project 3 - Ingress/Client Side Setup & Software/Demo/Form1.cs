using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net.Mail;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System.Speech.Synthesis;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;

namespace Demo
{
    public partial class Form1 : Form
    {
        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]

        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]

        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]

        private static extern int GetMenuItemCount(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        public object Key { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        //System level functions to be used for hook and unhook keyboard input  
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        //Declaring Global objects     
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;
        private MaterialSkinManager materialSkinManager;
        private IntPtr enable(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Disabling Windows keys 

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.Alt || objKeyInfo.key == Keys.LControlKey || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                {

                    return (IntPtr)0; // if 0 is returned then All the above keys will be enabled
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }
        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Disabling Windows keys 

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.Alt || objKeyInfo.key == Keys.LControlKey || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                {
                    
                    return (IntPtr)1; // if 0 is returned then All the above keys will be enabled
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }
        
        private void DisableTaskManager()
        {
            RegistryKey regkey = default(RegistryKey);
            string keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subKey);
                regkey.SetValue("DisableTaskMgr", keyValueInt);
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Registry Error!");
            }

        }
        String start_time;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            start_time = DateTime.Now.ToString();
                materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Red700, Accent.Red700, TextShade.WHITE);

                ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
                objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
                ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);

                int hwnd = FindWindow("Shell_TrayWnd", "");
                ShowWindow(hwnd, SW_SHOW);
                IntPtr hMenu = GetSystemMenu(this.Handle, false);

                int menuItemCount = GetMenuItemCount(hMenu);

                RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
                FormBorderStyle = FormBorderStyle.None;


            string mac1 = null;
            //MessageBox.Show("Hello");
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet && nic.OperationalStatus == OperationalStatus.Up)
                {

                    mac1 = nic.GetPhysicalAddress().ToString();
                    // MessageBox.Show(mac1);   
                }

            }

            //string mac = mac1.Substring(0, 2) + "-" + mac1.Substring(2, 2) + "-" + mac1.Substring(4, 2) + "-" + mac1.Substring(6, 2) + "-" + mac1.Substring(8, 2) + "-" + mac1.Substring(10, 2);
            String mac = "5C-26-0A-55-8F-46";
            //IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            //foreach (IPAddress address in localIPs)
            //    if (address.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        mac1=address.ToString();
            //        //MessageBox.Show(address.ToString());
            //    }                   
            try
            {
                con.Open();
                String query1 = "SELECT * FROM in_use_pc WHERE mac_id=@mac";
                //String query1 = "SELECT * FROM in_use_pc WHERE enrol = @enrol4 AND ip_address=@mac";
                MySqlCommand command1 = new MySqlCommand(query1, con);
                MySqlDataAdapter da = new MySqlDataAdapter(command1);
                DataTable dt = new DataTable();
                command1.Parameters.AddWithValue("@mac", mac);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtenroll.Text= dt.Rows[0][2].ToString();
                    (TabCont.TabPages[1] as Control).Enabled = false;
                }
                else
                {
                    (TabCont.TabPages[0] as Control).Enabled = false;
                    TabCont.SelectTab(1);
                }
            }
            catch (Exception)
            {

                panel1.Visible = false;
                panel2.Visible = true;
                //                MessageBox.Show(ex.ToString());                
            }
            finally
            {
                con.Close();
            }
            //MessageBox.Show(start_time);
            //DisableTaskManager();
            //EnableTaskManager();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                //do nothing, so return true;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

                if (e.Alt||e.KeyCode==Keys.RControlKey)
                {

                    //MessageBox.Show("hELLO");
                    e.Handled = true;
            }
        }
        private void EnableTaskManager()
        {
            RegistryKey regkey = default(RegistryKey);
            string keyValueInt = "-1";
            //0x00000000 (0)
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subKey);
                //regkey.DeleteSubKey("DisableTaskMgr");
                regkey.SetValue("DisableTaskMgr", keyValueInt);
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Registry Error!");
            }

        }
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root;database=rfid");
        String enroll;        
        protected bool check_user()
        {
            string mac1 = null;
            //MessageBox.Show("Hello");
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet && nic.OperationalStatus == OperationalStatus.Up)
                {

                    mac1 = nic.GetPhysicalAddress().ToString();
                    // MessageBox.Show(mac1);   
                }

            }
            string mac = "5C-26-0A-55-8F-46";
            //string mac = mac1.Substring(0, 2) + "-" + mac1.Substring(2, 2) + "-" + mac1.Substring(4, 2) + "-" + mac1.Substring(6, 2) + "-" + mac1.Substring(8, 2) + "-" + mac1.Substring(10, 2);
            
            //IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            //foreach (IPAddress address in localIPs)
            //    if (address.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        mac1=address.ToString();
            //        //MessageBox.Show(address.ToString());
            //    }           
            bool flag = false;
            try
            {                
                con.Open();
                String query1 = "SELECT * FROM in_use_pc WHERE enrol = @enrol4 AND mac_id=@mac";
                //String query1 = "SELECT * FROM in_use_pc WHERE enrol = @enrol4 AND ip_address=@mac";
                MySqlCommand command1 = new MySqlCommand(query1, con);
                MySqlDataAdapter da = new MySqlDataAdapter(command1);
                DataTable dt = new DataTable();
                command1.Parameters.AddWithValue("@enrol4", txtenroll.Text);
                command1.Parameters.AddWithValue("@mac", mac);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    flag = true;
                }
            }
            catch(Exception)
            {

                panel1.Visible = false;
                panel2.Visible = true;
//                MessageBox.Show(ex.ToString());                
            }   
            finally
            {
                con.Close();
            }                    
            return flag;
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(txtenroll.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Field Can't be empty......");
            }
            else
            {
                try

                {
                    
                    enroll = txtenroll.Text;
                    
                    //Check USER is valid or not
                    if(check_user()==true)
                    {
                        con.Open();
                        String query1 = "SELECT * FROM student_info WHERE enrol = @name1 AND password = @pass1";
                        MySqlCommand command1 = new MySqlCommand(query1, con);
                        MySqlDataAdapter da = new MySqlDataAdapter(command1);
                        DataTable dt = new DataTable();
                        command1.Parameters.AddWithValue("@name1", txtenroll.Text);
                        command1.Parameters.AddWithValue("@pass1", txtpass.Text);
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            String en = dt.Rows[0][1].ToString();
                            String name = dt.Rows[0][2].ToString();
                            this.Hide();

                            User_Info frm = new User_Info(en,name);
                            frm.ShowDialog();
                            //Process.Start(@"C:\Windows\System32\userinit.exe");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Enrollment or password...!!!");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("You have seat on wrong computer system or you have entered wrong enrollment number.....");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    panel1.Visible = false;
                    panel2.Visible = true;   
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            
        }

        private void txtenroll_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void Btnshutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");    // starts the shutdown application 
                                                     // the argument /s is to shut down the computer
                                                     // the argument /t 0 is to tell the process that 
                                                     // the specified operation needs to be completed 
                                                     // after 0 seconds
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
            //Process.Start("shutdown", "/s /t 0");    // starts the shutdown application 
                                                     // the argument /s is to shut down the computer
                                                     // the argument /t 0 is to tell the process that 
                                                     // the specified operation needs to be completed 
                                                     // after 0 seconds
        }
        
        
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "server=" + txtip.Text + ";user id=root;database=rfid;password=12345";
                con = new MySqlConnection(str);
                con.Open();
                con.Close();
                panel1.Visible = true;
                panel2.Visible = false;                

            }
            catch (Exception)
            {
                MessageBox.Show("Please check the IP address provided by you....");
            }
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(mac);
            try
            {                
                string mac1 = null, ip, pc_no;
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                        // Only consider Ethernet network interfaces
                    if ((nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up))
                    {
                            mac1 = nic.GetPhysicalAddress().ToString();              
                    }
                    
                    
                }
                //Because i am not connected with lan
                //string mac = mac1.Substring(0, 2) + "-"+ mac1.Substring(2, 2) + "-" + mac1.Substring(4, 2) + "-" + mac1.Substring(6, 2) + "-" + mac1.Substring(8, 2) + "-" + mac1.Substring(10, 2);

                string mac = "5C-26-0A-55-8F-46";
                
                con.Open();
                String query1 = "SELECT * FROM in_use_pc WHERE mac_id = @enrol";
                MySqlCommand command1 = new MySqlCommand(query1, con);
                MySqlDataAdapter da = new MySqlDataAdapter(command1);
                DataTable dt = new DataTable();
                command1.Parameters.AddWithValue("@enrol", mac);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {                    
                    ip = dt.Rows[0][1].ToString();
                    enroll= dt.Rows[0][2].ToString(); 
                    pc_no = dt.Rows[0][3].ToString();
                    con.Close();
                    con.Open();
                    String query = "INSERT INTO not_use_pc (ip_address, pc_number, mac_id) VALUES (@ip, @pc_no, @mac);";
                    MySqlCommand command = new MySqlCommand(query, con);
                                        
                    command.Parameters.AddWithValue("@ip", ip);
                    command.Parameters.AddWithValue("@pc_no", pc_no);
                    command.Parameters.AddWithValue("@mac", mac);

                    command.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    DataTable dt1 = new DataTable();
                    MySqlCommand command2 = new MySqlCommand("DELETE FROM in_use_pc WHERE mac_id=@Name1", con);
                    MySqlDataAdapter da1 = new MySqlDataAdapter(command2);
                    command2.Parameters.AddWithValue("@Name1", mac);
                    da1.Fill(dt1);
                    con.Close();

                    con.Open();
                    String query3 = "INSERT INTO log (pc_number, mac_id, enrol, start_time, end_time) VALUES (@pc_no,@mac, @enrol3,@start,@end);";
                    MySqlCommand command3 = new MySqlCommand(query3, con);
                    command3.Parameters.AddWithValue("@pc_no", pc_no);
                    command3.Parameters.AddWithValue("@mac", mac);
                    command3.Parameters.AddWithValue("@enrol3", enroll);
                    command3.Parameters.AddWithValue("@start", start_time);
                    command3.Parameters.AddWithValue("@end", DateTime.Now.ToString());
                    command3.ExecuteNonQuery();
                    con.Close();

                   
                }

            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
               
                con.Close();
            }

        }

        private void Form1_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void BtnGuest_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtguestno.Text) || string.IsNullOrWhiteSpace(txtguestpass.Text))
            {
                MessageBox.Show("Field Can't be empty......");
            }
            else
            {
                con.Close();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from guest_user where enrol=@enrol and password = @pass ", con);
                cmd.Parameters.AddWithValue("@enrol", txtguestno.Text);
                cmd.Parameters.AddWithValue("@pass", txtguestpass.Text);
                MySqlDataReader dr2 = cmd.ExecuteReader();
                
                if (dr2.HasRows==true)
                {
                    string name = null;
                    try
                    {
                        
                        while (dr2.Read())
                        {
                            name = dr2[1].ToString();
                        }
                         
                        con.Close();
                        string mac1 = null, ip, pc_no;
                        foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                        {
                            // Only consider Ethernet network interfaces
                            if ((nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                            nic.OperationalStatus == OperationalStatus.Up))
                            {
                                mac1 = nic.GetPhysicalAddress().ToString();
                            }


                        }

                        //string mac = mac1.Substring(0, 2) + "-" + mac1.Substring(2, 2) + "-" + mac1.Substring(4, 2) + "-" + mac1.Substring(6, 2) + "-" + mac1.Substring(8, 2) + "-" + mac1.Substring(10, 2);

                        string mac = "5C-26-0A-55-8F-46";
                        con.Open();
                        String query1 = "SELECT * FROM not_use_pc WHERE mac_id = @enrol";
                        MySqlCommand command1 = new MySqlCommand(query1, con);
                        MySqlDataAdapter da = new MySqlDataAdapter(command1);
                        DataTable dt = new DataTable();
                        command1.Parameters.AddWithValue("@enrol", mac);
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            ip = dt.Rows[0][0].ToString();                            
                            pc_no = dt.Rows[0][1].ToString();
                            con.Close();

                            con.Open();
                            String query = "INSERT INTO in_use_pc (mac_id, ip_address, enrol, pc_number, time_slot) VALUES ( @mac,@ip ,@enroll ,@pc_no, @time);";
                            MySqlCommand command = new MySqlCommand(query, con);
                            command.Parameters.AddWithValue("@mac", mac);
                            command.Parameters.AddWithValue("@ip", ip);
                            command.Parameters.AddWithValue("@enroll", txtguestno.Text);
                            command.Parameters.AddWithValue("@pc_no", pc_no);
                            command.Parameters.AddWithValue("@time", "01:00:00");
                            command.ExecuteNonQuery();
                            con.Close();

                            con.Open();
                            DataTable dt1 = new DataTable();
                            MySqlCommand command2 = new MySqlCommand("DELETE FROM not_use_pc WHERE mac_id=@Name1", con);
                            MySqlDataAdapter da1 = new MySqlDataAdapter(command2);
                            command2.Parameters.AddWithValue("@Name1", mac);
                            da1.Fill(dt1);
                            con.Close();
                            User_Info frm = new User_Info(txtguestno.Text, name);
                            this.Hide();
                            frm.Show();                                                    
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                 }
                else
                {
                    MessageBox.Show("Wrong user Id or password");
                }
            }



            //if (txtguestno.Text == "1234" && txtguestpass.Text == "1234")
            //{
            //    ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            //    objKeyboardProcess = new LowLevelKeyboardProc(enable);
            //    ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);

            //    enroll = txtguestno.Text;
            //    this.Hide();
            //    Process.Start(@"C:\Windows\System32\userinit.exe");
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect User Name or Password....");
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            String h_temp = null, m_temp = null, s_temp = null;
            int h, m, s;
            String time = txtTimer.Text;
            for (int i = 0; i < time.Length; i++)
            {
                if (i == 0 || i == 1)
                {

                    h_temp = h_temp + time[i];
                }
                if (i == 3 || i == 4)
                {
                    m_temp = m_temp + time[i];
                }
                if (i == 6 || i == 7)
                {
                    s_temp = s_temp + time[i];
                }
            }
            if (h_temp == "00" && m_temp == "00" && s_temp == "0")
            {
                //MessageBox.Show("Your Time is Up...");
                Close();
            }
            h = int.Parse(h_temp);
            m = int.Parse(m_temp);
            s = int.Parse(s_temp);
            if (h == 0 && m <= 01 && s == 0)
            {
                timer2.Enabled = true;
                LblRemaining.ForeColor = Color.Red;
                //LblRemaining.ForeColor = Color.DarkBlue;
            }
            if (s == 0)
            {
                s = 60;
                if (m == 0)
                {
                    m = 60;
                    h--;
                }
                m--;
            }
            s--;
            if (m >= 10)
            { txtTimer.Text = "0" + h.ToString() + ":" + m.ToString() + ":" + s.ToString(); }
            else
            { txtTimer.Text = "0" + h.ToString() + ":" + "0" + m.ToString() + ":" + s.ToString(); }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (LblRemaining.Visible == false)
            {
                LblRemaining.Visible = true;
            }
            else
            {
                LblRemaining.Visible = false;
            }

        }

        private void forgotpass_Click(object sender, EventArgs e)
        {

        }
    }
}