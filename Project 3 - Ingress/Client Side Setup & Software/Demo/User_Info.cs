using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MySql.Data.MySqlClient;

namespace Demo
{
    public partial class User_Info : Form
    {
        String enroll, std_name;
        public User_Info(String en, String name)
        {
            enroll = en;
            std_name = name;
            InitializeComponent();
        }
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

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

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root;database=rfid");
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

        private void User_Info_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Red700, Accent.Red700, TextShade.WHITE);           
            
            lblenroll.Text = enroll;
            lblname.Text = std_name;
            txtenroll.Text = enroll;
            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(@"Select * FROM log where enrol = "+enroll+ " ORDER BY start_time DESC LIMIT 5", con);
                DataTable dt = new DataTable();              
                da.Fill(dt);
                lastlogs.DataSource = dt;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Hide();

            Timer frm = new Timer();
            frm.Show();

            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(enable);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            Process.Start(@"C:\Windows\System32\userinit.exe");
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Hide();

            Timer frm = new Timer();
            frm.Show();

            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(enable);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            Process.Start(@"C:\Windows\System32\userinit.exe");

        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtenroll.Text);
            if (string.IsNullOrWhiteSpace(txtenroll.Text) || string.IsNullOrWhiteSpace(txtoldpass.Text) || string.IsNullOrWhiteSpace(txtnewpass.Text))
            {
                MessageBox.Show("Field Can't be empty......");
            }
            else
            {
                con.Close();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from student_info where enrol=@enrol and password = @pass ", con);
                cmd.Parameters.AddWithValue("@enrol", txtenroll.Text);
                cmd.Parameters.AddWithValue("@pass", txtoldpass.Text);
                MySqlDataReader dr2 = cmd.ExecuteReader();
                if (dr2.FieldCount>0)
                {
                    con.Close();
                    con.Open();
                    MySqlCommand cmd1 = new MySqlCommand("UPDATE student_info SET password=@pass where enrol=@enrol", con);
                    cmd1.Parameters.AddWithValue("@enrol", txtenroll.Text);
                    cmd1.Parameters.AddWithValue("@pass", txtnewpass.Text);
                    int result1 = cmd1.ExecuteNonQuery();
                    if (result1 != 0)
                    {
                        MessageBox.Show("Password Reseted Sucessfully");

                    }
                    else
                    {
                        MessageBox.Show("Sorry!!Something Went Wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Old password is not match with your existing password.");
                }
                con.Close();            
            }
        }

        private void Logs_Click(object sender, EventArgs e)
        {

        }
    }
}
