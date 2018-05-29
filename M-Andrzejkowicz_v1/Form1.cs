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
        List<List<string>> TablicaRzeczy = new List<List<string>>();
        List<string> Wiersz = new List<string>();
        Boolean dodajWiersz = true;
        String WatchStatus = "LISTENING";
        String DefaultGetaway = "";
        Process Process = new System.Diagnostics.Process();
        String PASSWORD=""; // HASŁO DO SIECI WIFI
        String SSID = ""; // SSID WIFI
        String SZYFROWANIE = ""; //SZYFROWANIE
        PasswordStrength SprawdzaczSilyHasla = new PasswordStrength();

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            ipAddress = NetworkGateway();
            SkanujPodsiec();

            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 5000;
            myTimer.Start();


        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            
            String PingOutput = (CmdQuery("ping ", DefaultGetaway + " -n 1"));
            if (PingOutput.IndexOf("unreachable") >= 0)
            {
                Console.WriteLine("ALARM! NIE UDAŁO SIE SPINGOWAC!");
                IntervalPingTextbox.Text = "Pingowanie " + DefaultGetaway + "ZJEBAWSZY! ALARM! \r\n " + DateTime.Now;
                log_textbox.AppendText("Pingowanie " + DefaultGetaway + "ZJEBAWSZY! ALARM! " + DateTime.Now + "\r\n");
                AlarmBox.BackColor = Color.Red;
            }
            else
            {
                Console.WriteLine("Pingowanie Default Gatewaya w porządku :3");
                IntervalPingTextbox.Text = "Pingowanie "+DefaultGetaway+" OK \r\n " + DateTime.Now;
                log_textbox.AppendText("================================\r\n");
                log_textbox.AppendText("Pingowanie " + DefaultGetaway + " OK \r\n " + DateTime.Now +"\r\n");
                log_textbox.AppendText("================================\r\n");
                AlarmBox.BackColor = Color.Green;
            }

        }

        private string CmdQuery(string FileName, string Arguments = "")
        {



            //string macAddress = string.Empty;

            Process.StartInfo.FileName = FileName;
            Process.StartInfo.Arguments = Arguments;
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = true;
            Process.Start();
            string output = Process.StandardOutput.ReadToEnd();
            while (output.IndexOf("  ") > 0)
            {
                output = output.Replace("  ", " ");
            }
            return output;
        } // Funkcja wywołuje jakąś rzecz w CMD i zwraca string z CMD
        private void CmdQueryAdmin(string Argument)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand;
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + Argument;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
            Console.WriteLine("Wykonano zadanie admin CmdQueryAdmin: "+ Argument);
        }
        private void skanuj_button_Click(string ipAddress)
        {

            string strOutput = CmdQuery("netstat", "-ano");
            


            //Console.WriteLine("StrOutput" + strOutput);
            //log_textbox.Text = strOutput;

            Wiersz.Clear();
            TablicaRzeczy.Clear();
            dodajWiersz = true;

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



            foreach (var substring in substrings)
            {
                // SPRAWDZANIE CZY W JAKIMŚ WIERSZU SĄ JAKIEŚ RZECZY!
                Wiersz.Add(substring.Replace("|",""));
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


            //int matches = Regex.Matches(strOutput, "0.0.0.0").Count;
            //Console.WriteLine("{0} occurrences", matches);
            //Console.WriteLine("Podsłuchuje cie " + matches + " koleszków");

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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WatchStatus = "LISTENING";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            WatchStatus = "ESTABLISHED";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            WatchStatus = "CLOSE_WAIT";
        }
        private void SprawdzPodsluchy()
        {
            //Przejedz znow przez tablice i sprawdz czy ktos nas podsłuchuje
            int index = 0;
            foreach (List<string> y in TablicaRzeczy)
            {
                if (y[7] != "0" || y[8] != "0" || y[9] != "0" || y[10] != "0")
                {
                    if (y[11] == WatchStatus)
                    {
                        Console.WriteLine("PODSŁUCH! na pozycji: " + index);
                        podsluch_alert.Text = "WYKRYTO PODSŁUCH!";
                        LISTA.Items[index].BackColor = Color.Red;
                    }
                    Console.WriteLine("MAMY NIEZEROWE FOREIGNY!");
                }
                index++;
            }
        }
        private void SkanujPodsiec()
        {
            Console.WriteLine(CmdQuery("ipconfig"));
            String[] TabelaIpConfig = CmdQuery("ipconfig").Split('\n');
            Console.WriteLine();
            for(int i=0; i<TabelaIpConfig.Length; i++) // szukaj IP
            {
                if(TabelaIpConfig[i].IndexOf("Default Gateway") >=0) // Jesli w linijce znajduje sie IPv4
                {
                    TabelaIpConfig[i] = TabelaIpConfig[i].Remove(0, TabelaIpConfig[i].IndexOf(':')+1).Trim();
                    Console.WriteLine("wypisuje!");
                    DefaultGetaway = TabelaIpConfig[i];
                    Console.WriteLine(DefaultGetaway);
                }

            }
        }
        private async void skanuj_button_Click(object sender, EventArgs e)
        {
            podsluch_alert.Text = "CZYSTO :3";
            LISTA.Items.Clear();
            skanuj_button_Click(ipAddress);
            SprawdzPodsluchy();
            SkanujPodsiec();
            CmdQueryAdmin("arp -d");






        }



        private Task ProcessData(IProgress<ProgressReport> progress)
        {
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {

                for (int i = 0; i < hScrollBar1.Value+2; i++)
                {
                    string IpAddress = DefaultGetaway;
                    String Query = (CmdQuery("ping", " 192.168.0." + i + " -n 1"));
                    Console.WriteLine(Query);
                    progressReport.PercentComplete = i;
                    progressReport.ConsoleOutput = Query;
                    progress.Report(progressReport);
                }
                progressReport.PercentComplete = 0;
                progressReport.ConsoleOutput = "\r\n======================================\r\n " +
                                                "Pingowanie podsieci zakończone powodzeniem " +
                                                "\r\n======================================\r\n";



            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //URUCHOM THREADA
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {

                progressBar1.Value = report.PercentComplete*100/hScrollBar1.Value;
                Progress_text_box.Text = report.PercentComplete.ToString();
                log_textbox.AppendText(report.ConsoleOutput);
                progressBar1.Update();
            };
            await ProcessData(progress);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            zakres_text_box.Text = hScrollBar1.Value.ToString();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Aplikacja zminimalizowana :3";
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;

            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void SprawdzNazweWifi()
        {
            SSID = CmdQuery("Netsh", " WLAN show interfaces");
            SSID = ZnajdzLinijke(SSID, "SSID");
            SSID = SSID.Replace("SSID:", "");
            Console.WriteLine(SSID);
            NazwaWifi.Text = SSID;
        }
        private void SprawdzSzyfrowanieWifi()
        {
            SZYFROWANIE = CmdQuery("Netsh", " WLAN show interfaces");
            SZYFROWANIE = ZnajdzLinijke(SZYFROWANIE, "Authentication");
            SZYFROWANIE = SZYFROWANIE.Replace("Authentication:", "");
            Console.WriteLine(SZYFROWANIE);
            szyfrowanie.Text = SZYFROWANIE;
        }
        private void SprawdzHasłoWifi()
        {
            PASSWORD = CmdQuery("netsh", " wlan show profile name=\"Domek\" key=clear");
            PASSWORD = ZnajdzLinijke(PASSWORD, "Key Content");
            PASSWORD = PASSWORD.Replace("KeyContent:", "");
            Console.WriteLine(PASSWORD);
            HasloWifi.Text = PASSWORD;
            twojehaslo.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SprawdzNazweWifi();
            SprawdzHasłoWifi();
            SprawdzSzyfrowanieWifi();
            SprawdzanieSilyHasla();
        }

        string ZnajdzLinijke(string input, string StartString)
        {
            String output;

            output = input.Remove(0, input.IndexOf(StartString));

            output = output.Remove(output.IndexOf("\n"), output.Length-output.IndexOf("\n"));

            output = output.Replace("\n", "");
            output = output.Replace("\r", "");
            output = output.Replace(" ", "");


            return output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HasloWifi.UseSystemPasswordChar = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HasloWifi.UseSystemPasswordChar = true;
        }

        private void SprawdzanieSilyHasla()
        {
            log_textbox.AppendText("\r\n ======================================\r\n"+SprawdzaczSilyHasla.CheckStrength(SSID, PASSWORD)+"\r\n ======================================\r\n");
        }
    }
}
