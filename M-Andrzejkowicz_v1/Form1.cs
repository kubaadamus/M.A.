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
            

            //Console.WriteLine("StrOutput" + strOutput);
            log_textbox.Text = strOutput;


            Char[] delimiter = {' ','.',':'};
            String[] substrings = strOutput.Split(delimiter);

            for(int i=0; i<substrings.Length; i++)
            {
                if(substrings[i].IndexOf("\r\n")>0)
                {
                    substrings[i] = substrings[i].Replace("\r\n\r\n", "|");
                    substrings[i] = substrings[i].Replace("\r\n", "|");
                }
                else
                {
                    substrings[i] = substrings[i].Replace("\r\n\r\n", "");
                    substrings[i] = substrings[i].Replace("\r\n", "");
                }

            }

            List<List<string>> TablicaRzeczy = new List<List<string>>();
            List<string> Wiersz = new List<string>();
            Boolean dodajWiersz = true;

            foreach (var substring in substrings)
            {
                Wiersz.Add(substring);
                if(substring.IndexOf("[") >= 0 || substring.IndexOf("*") >= 0 || substring.IndexOf("Active") >= 0 || substring.IndexOf("Proto") >= 0)
                {
                    dodajWiersz = false;
                }
                if(substring.IndexOf("|")>=0)
                {
                    if(dodajWiersz)
                    {
                        TablicaRzeczy.Add(new List<string>(Wiersz));
                    }
                    Wiersz.Clear();
                    dodajWiersz = true;
                }
            }
            Console.WriteLine("ITERUJEMY!");
            //Iterujemy poprzez listę list
            int index = 0;
            foreach ( List<string> y in TablicaRzeczy)
            {
                ListViewItem lvi = new ListViewItem(index.ToString());
                index++;
                foreach(string x in y)
                {
                    Console.Write(""+x+"");
                    lvi.SubItems.Add(x);
                }
                LISTA.Items.Add(lvi);
            }


            Console.WriteLine("lolz");


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

    }
}
