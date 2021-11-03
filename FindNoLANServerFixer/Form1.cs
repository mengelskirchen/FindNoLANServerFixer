using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Diagnostics;

namespace FindNoLANServerFixer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            cbx_interfaces.DisplayMember = "Description";
            fetchNetworkInterfaces();
        }

        private void button1_Click(object sender, EventArgs e) {
            NetworkInterface ni = (NetworkInterface)cbx_interfaces.SelectedItem;
            int interfaceIndex = ni.GetIPProperties().GetIPv4Properties().Index;
            String cmd1 = " /C route -4 ADD 255.255.255.255 MASK 255.255.255.255 0.0.0.0 METRIC 20 IF " + interfaceIndex;
            String cmd2 = " /C route -4 CHANGE 255.255.255.255 MASK 255.255.255.255 0.0.0.0 METRIC 20 IF " + interfaceIndex;
            Console.WriteLine(cmd1);
            Process p1 = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;
            psi.Verb = "runas";
            psi.FileName = "cmd.exe";
            psi.Arguments = @cmd1;
            p1.StartInfo = psi;
            p1.Start();
            p1.Close();
            psi.Arguments = @cmd2;
            p1.Start();
            p1.Close();
            MessageBox.Show("Der Server sollte nun zu finden sein.\r\nAlle Änderungen werden bei einem Windows-Neustart zurückgesetzt.","Fertig!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void fetchNetworkInterfaces() {
            cbx_interfaces.Items.Clear();
            int lastIndex = 0;
            NetworkInterface selectThis = null;
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces()) {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                    ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    ni.NetworkInterfaceType == NetworkInterfaceType.FastEthernetT ||
                    checkBox1.Checked) {
                    cbx_interfaces.Items.Add(ni);
                    if (lastIndex < ni.GetIPProperties().GetIPv4Properties().Index) {
                        selectThis = ni;
                        lastIndex = ni.GetIPProperties().GetIPv4Properties().Index;
                    }
                }
            }
            if (selectThis != null) {
                cbx_interfaces.SelectedItem = selectThis;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            fetchNetworkInterfaces();
        }
    }
}
