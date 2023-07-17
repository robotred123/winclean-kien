using System;
using System.Windows.Forms;
using System.Management;
using AutoUpdaterDotNET;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Documents;
using System.Threading.Tasks;
using System.Timers;

namespace Clean_Recycle
{
    public partial class FrmHome : Form
    {
        #region Create Dll
        private static string StrCon = ConfigurationManager.ConnectionStrings["connectSQL"].ToString();
        private static string[] ad = StrCon.Split(';', '='); string[] ac = ad[1].Split(',', ' ');
        public static DataTable dt_BasicPolicy;
        public static List<string> ma_Scrip = new List<string>(), time_start = new List<string>();
        public static List<string> xapth = new List<string>();
        #endregion
        public FrmHome()
        {
            InitializeComponent();
/*            Startup.IsInStartup();
            Startup.RunOnStartup();*/
            const double interval60Minutes = 60 * 60 * 1000; // milliseconds to one hour
            System.Timers.Timer checkForTime = new System.Timers.Timer(interval60Minutes);
            checkForTime.Elapsed += new ElapsedEventHandler(checkForTime_Elapsed);
            checkForTime.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            var fpath = AppDomain.CurrentDomain.BaseDirectory + "\\bin\\KeyBoard_Test.exe"; ;
                        Process.Start(fpath);*/
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private bool CheckAll()
        {
            DayOfWeek day = DateTime.Now.DayOfWeek;
            if(day != DayOfWeek.Thursday)
            {
                return false;
            }
            TimeSpan start = new TimeSpan(15, 0, 0); //10 o'clock
            TimeSpan end = new TimeSpan(14, 0, 0); //12 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;
            if((now > start) || (now < end))
            {
                return false;
            }
            return true;
        }

        private void checkForTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (CheckAll()) { 
                CleanBtn_Click(new object(), new EventArgs());
                MessageBox.Show("K/G các cơ quan đơn vị thực hiện chế độ tổng dọn vệ sinh doanh trại");
            }
            
        }
        private void CleanBtn_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt_BasicPolicy.Rows)
            {
                string xPath = row["Name_scripts"].ToString(); string[] path = xPath.Split('\r', '\n'); var xpat = path[0].ToString();
                xapth.Add(xpat);
                time_start.Add(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                ma_Scrip.Add(row["ID"].ToString());
                count_.Add(xpat);
            }
            Thread thread = new Thread(new ThreadStart(Select_SQL.Load_Basicxml)); thread.Start();
        }



        public static void check_()
        {
            AlertBox();
        }

        public static string thongbao_hile;
        private static void AlertBox()
        {
            Frm_AlertBox frm_Alert = new Frm_AlertBox();
            frm_Alert.ShowDialog();
        }
        public static List<string> count_ = new List<string>();

        private static void CheckTemperature()
        {
            
        }
        private void Temperature(object sender, ElapsedEventArgs e)
        {
/*            Double CPUtprt = 0;
            ManagementObjectSearcher mos = new ManagementObjectSearcher(@"root\WMI", "Select * From MSAcpi_ThermalZoneTemperature");
            foreach (ManagementObject mo in mos.Get())
            {
                CPUtprt = Convert.ToDouble(Convert.ToDouble(mo.GetPropertyValue("CurrentTemperature").ToString()) - 2732) / 10;
                lb_Tempertature.Text = "Nhiệt độ CPU:" + CPUtprt.ToString() + " °C";
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal; 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }


        private void FrmHome_Load(object sender, EventArgs e)
        {
            label1.Text = "Recyle Clean Version: " + Update_App.version;
            AutoUpdater.CheckForUpdateEvent += Update_App.AutoUpdaterOnCheckForUpdateEvent;
            Select_SQL.Load_BasicPolicy();
            /*            const double intervalSeconds = 1000; // milliseconds
                        System.Timers.Timer checkForTime = new System.Timers.Timer(intervalSeconds);
                        checkForTime.Elapsed += new ElapsedEventHandler(Temperature);
                        checkForTime.Enabled = true;*/
            lb_IPadd.Text = "Địa chỉ IP: " + Connect_SQL.ipaddress;
            lb_MAC.Text = "Địa chỉ MAC: " + Connect_SQL.mac;
            lb_NamePC.Text = "Server IP: " + ac[1];
        }
    }
}
