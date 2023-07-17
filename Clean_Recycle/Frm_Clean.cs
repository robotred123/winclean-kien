using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace Clean_Recycle
{
    public partial class Frm_Clean : Form
    {
        #region Create Dll
        private static string StrCon = ConfigurationManager.ConnectionStrings["connectSQL"].ToString();
        private static string[] ad = StrCon.Split(';', '='); string[] ac = ad[1].Split(',', ' ');
        public static DataTable dt_Policy;
        public static List<string> ma_Scrip = new List<string>(), time_start = new List<string>();
        public static List<string> xapth = new List<string>();
        #endregion

        #region Notification Area Icon Event Handlers
        private void Frm_Clean_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                _oldState = WindowState;

            Visible = WindowState != FormWindowState.Minimized;
        }



        private FormWindowState _oldState = FormWindowState.Normal;

        private void _notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Visible = true;
                WindowState = _oldState;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
                Visible = false;
            }
        }

        private void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState != FormWindowState.Minimized)
                    Activate();
            }
        }


        private void _nimRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
            {
                Visible = true;
                WindowState = _oldState;
            }
        }

        private void _nimMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void _nimExit_Click(object sender, EventArgs e)
        {
            Process[] workers = Process.GetProcessesByName("Clean_Recycle");
            foreach (Process worker in workers)
            {
                worker.Kill();
                worker.WaitForExit();
                worker.Dispose();
            }
        }

        #endregion

        public Frm_Clean()
        {
            InitializeComponent();
            Update_App.version_();
            // Check connect Server Database
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ac[1].ToString(), Convert.ToInt32(ac[2].ToString()));
                Stream stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được cơ sở dữ liệu!\n Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Clean_Load(object sender, EventArgs e)
        {
            lb_mess.Text = "Recyle Clean Version: " + Update_App.version;
            AutoUpdater.CheckForUpdateEvent += Update_App.AutoUpdaterOnCheckForUpdateEvent;
            Select_SQL.Load_Policy();
            dataGV_Scripts.DataSource = dt_Policy;
            Thread thread = new Thread(new ThreadStart(Auto_Policy.start_auto));
            thread.Start();
        }

        private void dataGV_Scripts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var center = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height); e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, center);
        }

        private void dataGV_Scripts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_Scripts.SelectedRows.Count > 0)
            {
                string tDetails = dataGV_Scripts.SelectedRows[0].Cells["col_Details"].Value + string.Empty;
                txt_Details.Text = tDetails;
                bool isSelected = Convert.ToBoolean(dataGV_Scripts.SelectedRows[0].Cells["col_check"].Value);
                if (isSelected != true)
                {
                    dataGV_Scripts.SelectedRows[0].Cells["col_check"].Value = true;
                    int ind = Convert.ToInt32(dataGV_Scripts.CurrentCell.RowIndex);
                    dataGV_Scripts.Rows[ind].DefaultCellStyle.BackColor = Color.Aqua;
                }
                else
                {
                    dataGV_Scripts.SelectedRows[0].Cells["col_check"].Value = false;
                    int ind = Convert.ToInt32(dataGV_Scripts.CurrentCell.RowIndex);
                    dataGV_Scripts.Rows[ind].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void Bnt_Excute_scripts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGV_Scripts.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["col_check"].Value);
                if (isSelected == true)
                {
                    string xpath = row.DataGridView.Rows[Convert.ToInt32(row.Index)].Cells["col_Name_scripts"].Value.ToString(); string[] path = xpath.Split('\r', '\n'); var xpat = path[0].ToString();
                    xapth.Add(xpat);
                    time_start.Add(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                    ma_Scrip.Add(row.DataGridView.Rows[Convert.ToInt32(row.Index)].Cells["col_ID"].Value.ToString());
                    count_.Add(xpat);
                }
            }
            Thread thread = new Thread(new ThreadStart(Select_SQL.Load_xml)); thread.Start();
        }

        public static List<string> count_ = new List<string>();
        public static string thongbao_hile;

        public static void check_()
        {
            AlertBox();
        }


        private static void AlertBox()
        {
            Frm_AlertBox frm_Alert = new Frm_AlertBox();
            frm_Alert.ShowDialog();
        }
    }
}
