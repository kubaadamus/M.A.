using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;

namespace M_Andrzejkowicz_v1
{
    public partial class Form1 : Form
    {
        string ipAddress;
        string[] connections_array;

        public Form1()
        {
            InitializeComponent();
            ipAddress = NetworkGateway();
            skanuj_button_Click(ipAddress);




        }



        private void skanuj_button_Click(string ipAddress)
        {
            string macAddress = string.Empty;
            Process Process = new System.Diagnostics.Process();
            Process.StartInfo.FileName = "netstat";
            Process.StartInfo.Arguments = "-ano";
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = true;
            Process.Start();
            string strOutput = Process.StandardOutput.ReadToEnd();
            while(strOutput.IndexOf("  ")>0)
            {
                strOutput = strOutput.Replace("  ", " ");
            }
            

            Console.WriteLine("StrOutput" + strOutput);
            log_textbox.Text = strOutput;


            Char delimiter = ' ';
            String[] substrings = strOutput.Split(delimiter);

            foreach (var substring in substrings)
            {
                Console.WriteLine(substring + "//");
            }

            
            int matches = Regex.Matches(strOutput, "0.0.0.0").Count;
            Console.WriteLine("{0} occurrences", matches);
            Console.WriteLine("Podsłuchuje cie " + matches + " koleszków");

        }
        static string NetworkGateway()
        {
            string ip = null;

            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        if (ip == null)
                            ip = d.Address.ToString();
                    }
                }
            }
            Console.WriteLine("wypisuje ip");
            Console.WriteLine(ip);
            return ip;
        }

        private void log_label_Click(object sender, EventArgs e)
        {

        }
    }
}
