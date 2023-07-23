using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Panel
{
    class Connect_with_PI
    {
        string localIP;
        //string localIP="";
        public string getip() {
            String myhostname = "raspberrypi";
            try
            {
                IPHostEntry host;
                host = Dns.GetHostEntry(myhostname);
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                    }
                }

            }
            catch (Exception )
            {
                MessageBox.Show("Could not Connect to Raspberry PI Server !! TRYING Some Alternative...");
                
                Connect_2_PI obj = new Connect_2_PI();
                obj.ShowDialog();

            }
            return localIP;
        }
    }
}
