using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
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
            if (h == 0 && m<=01 && s==1)
            {
                timer2.Enabled = true;  
                txtTimer.ForeColor = Color.Red;
                label1.ForeColor = Color.DarkBlue;
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
            if (label1.Visible == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root;database=rfid");
        private void Timer_Load(object sender, EventArgs e)
        {
            string mac1 = null;
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
            command1.Parameters.AddWithValue("@enrol", mac);
            MySqlDataReader dr = command1.ExecuteReader();
            if (dr.FieldCount > 0)
            {
                while(dr.Read())
                {
                    txtTimer.Text = dr["time_slot"].ToString();
                }
                
            }
       }
    }
}
