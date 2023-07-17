using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Clean_Recycle
{
    static class Program
    {
        private static string StrCon = ConfigurationManager.ConnectionStrings["connectSQL"].ToString();
        private static string[] ad = StrCon.Split(';', '=');
        private static string[] ac = ad[1].Split(',', ' ');
        [STAThread]
        static void Main()
        {
            Process[] workers = Process.GetProcessesByName("Clean_Recycle");
            foreach (Process worker in workers)
            {
                if(workers.Length > 1)
                {
                    if (worker.Id == workers[1].Id) { }
                    else
                    {
                        worker.Kill();
                        worker.WaitForExit();
                        worker.Dispose();
                        MessageBox.Show("Clean Recycle đang hoạt động!\n Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ac[1].ToString(), Convert.ToInt32(ac[2].ToString()));
                Stream stream = client.GetStream();
                Connect_SQL.GetMacAddress();
                Select_SQL.Load_Dm_Canbo(Connect_SQL.mac);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
                MessageBox.Show("SOS!! Không kết nối được cơ sở dữ liệu!\n Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread t1 = new Thread(new ThreadStart(Frm_Update.check_auto));
            t1.Start();
            if (Select_SQL.dt.Rows.Count > 0) { Application.Run(new FrmHome()); } else { Application.Run(new Frm_Dm_CB()); }
        
        }
    }
}
