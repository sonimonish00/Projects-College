using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using InTheHand.Net;

namespace Bluetooth_Scanning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refresh_btn.PerformClick();
        }

        BluetoothClient thisDevice = new BluetoothClient();
        BluetoothDeviceInfo[] devices;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstNetworks.Items.Clear();
            
            //Scan for bluetooth devices in range
            devices = thisDevice.DiscoverDevices();

            //Write the type of each device
            foreach (BluetoothDeviceInfo device in devices)
            {
                ListViewItem item = new ListViewItem(device.DeviceName);
                item.SubItems.Add(device.DeviceAddress.ToString());
                item.SubItems.Add(device.Remembered.ToString());
                item.SubItems.Add(device.ClassOfDevice.MajorDevice.ToString());
                item.SubItems.Add(device.Authenticated.ToString());
                item.SubItems.Add(device.Connected.ToString());
                item.SubItems.Add(device.LastSeen.ToString());
                item.SubItems.Add(device.LastUsed.ToString());
                lstNetworks.Items.Add(item);
            }
        }

        int counter = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "auto refresh in " + counter + " secounds";
            counter--;
            if (counter == -1)
            {
                label1.Text = "Refreshing...";
                //refresh_btn.PerformClick();
                counter = 20;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = lstNetworks.SelectedIndices[0];

                if (BluetoothRadio.PrimaryRadio.Mode == RadioMode.PowerOff)
                    BluetoothRadio.PrimaryRadio.Mode = RadioMode.Connectable;

                DialogResult result = MessageBox.Show("Send File to " + devices[selected].DeviceName, "Send File", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    devices[selected].Update();
                    devices[selected].Refresh();
                    devices[selected].SetServiceState(BluetoothService.ObexObjectPush, true);
                    if (devices[selected].Authenticated)
                    {
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            var file = openFileDialog1.FileName;
                            var uri = new Uri("obex://" + devices[selected].DeviceAddress + "/" + file);
                            var request = new ObexWebRequest(uri);
                            request.ReadFile(file);
                            var response = (ObexWebResponse)request.GetResponse();
                            MessageBox.Show(response.StatusCode.ToString());
                            response.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Device Not Paired..");
                    }
                }
            }catch
            {
                MessageBox.Show("Exeption.."); 
            }
        }
    }
}
