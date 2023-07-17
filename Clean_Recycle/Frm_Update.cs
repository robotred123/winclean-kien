using AutoUpdaterDotNET;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Clean_Recycle
{
    public partial class Frm_Update : Form
    {
        public Frm_Update()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            label1.Text = "Phiên bản: " + fvi.FileVersion;
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheck;
            AutoUpdater.DownloadPath = "update";
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 15 * 60 * 1000,
                SynchronizingObject = this
            };
            timer.Elapsed += delegate
            {
                AutoUpdater.Start("http://172.16.150.35:3000/update.xml");
            };
            timer.Start();
            check_auto();
        }

        private static void AutoUpdaterOnCheck(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {
                Update_App.AutoUpdaterOnCheckForUpdateEvent(args);
            }
            check_auto();
        }

        public static void check_auto()
        {
            Thread.Sleep(9000);
            AutoUpdater.Start("http://172.16.150.35:3000/update.xml");
        }
    }
}
