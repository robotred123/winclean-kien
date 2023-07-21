using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Clean_Recycle
{
    public partial class Frm_Dm_CB : Form
    {
        #region Create dll
        private static bool check_start; public static DataTable dt_Macb, dt_dmcb;
        public static DataTable dt_dvc1, dt_dvc2, dt_dvc3, dt_dvc4;
        private static string StrCon = ConfigurationManager.ConnectionStrings["connectSQL"].ToString();
        private static string[] ad = StrCon.Split(';', '='); string[] ac = ad[1].Split(',', ' ');
        #endregion

        public Frm_Dm_CB()
        {
            InitializeComponent();
            _btnOK.Enabled = false;
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ac[1].ToString(), Convert.ToInt32(ac[2].ToString()));
                Stream stream = client.GetStream();
                Connect_SQL.GetMacAddress();
                Select_SQL.Dv_cap1();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được cơ sở dữ liệu!\n Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region load combo don vi
        private void Load_Dvc1()
        {
            for (int i = 0; i <= dt_dvc1.Rows.Count; i++)
            {
                cb_dvc1.ValueMember = "Units_c1";
                cb_dvc1.DisplayMember = "Ten_donvi";
                cb_dvc1.DataSource = dt_dvc1;
            }
        }
        private void Load_Dvc2(string Units_c1)
        {
            Select_SQL.Dv_cap2(Units_c1);
            for (int i = 0; i <= dt_dvc2.Rows.Count; i++)
            {
                cb_dvc2.ValueMember = "Units_c2";
                cb_dvc2.DisplayMember = "Ten_donvi";
                cb_dvc2.DataSource = dt_dvc2;
            }
        }
        private void Load_Dvc3(string Units_c2)
        {
            Select_SQL.Dv_cap3(Units_c2);
            for (int i = 0; i <= dt_dvc3.Rows.Count; i++)
            {
                cb_dvc3.ValueMember = "Units_c3";
                cb_dvc3.DisplayMember = "Ten_donvi";
                cb_dvc3.DataSource = dt_dvc3;
            }
        }
        private void Load_Dvc4(string Units_c3)
        {
            Select_SQL.Dv_cap4(Units_c3);
            for (int i = 0; i <= dt_dvc4.Rows.Count; i++)
            {
                cb_dvc4.ValueMember = "Units_c4";
                cb_dvc4.DisplayMember = "Ten_donvi";
                cb_dvc4.DataSource = dt_dvc4;
            }
        }
        #endregion

        private void Frm_Dm_CB_Load(object sender, EventArgs e)
        {
            Load_Dvc1();
            Select_SQL.Load_Dm_Canbo(Connect_SQL.mac);
            lb_NamePC.Text = "Computer name:    " + Environment.MachineName.ToString();
            lb_MAC.Text = "Địa chỉ MAC:     " + Connect_SQL.mac;
            if (dt_dmcb.Rows.Count > 0) { cb_dvc1.Text = dt_dmcb.Rows[0]["dv_cap1"].ToString(); cb_dvc2.Text = dt_dmcb.Rows[0]["dv_cap2"].ToString(); cb_dvc3.Text = dt_dmcb.Rows[0]["dv_cap3"].ToString(); cb_dvc4.Text = dt_dmcb.Rows[0]["dv_cap4"].ToString(); txt_hoten.Text = dt_dmcb.Rows[0]["Hoten"].ToString(); txt_chucvu.Text = dt_dmcb.Rows[0]["Position"].ToString(); _cbStartWithWindows.Checked = Convert.ToBoolean(dt_dmcb.Rows[0]["Auto_start"].ToString()); }
        }

        public string ID_Ma()
        {
            Select_SQL.Load_MaCB();
            string ap = "CB";
            string ma = Connect_SQL.mac;
            ma = ma.Replace("-",string.Empty);

            /*            int s = 0;

                        if (dt_Macb.Rows.Count <= 0 && dt_Macb.ToString() != null)
                        {
                            ap = "CB001";
                        }
                        else
                        {
                            s = Convert.ToInt32(dt_Macb.Rows.Count.ToString());
                            s = s + 1;
                            ap = ap + s.ToString();
                        }*/
            ap = ap + ma.Substring(ma.Length - 6, 6);
            return ap;
        }

        private void cb_dvc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Dvc2(cb_dvc1.SelectedValue.ToString());
        }

        private void cb_dvc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Dvc3(cb_dvc2.SelectedValue.ToString());
        }

        private void cb_dvc3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Dvc4(cb_dvc3.SelectedValue.ToString());
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            if (dt_dmcb.Rows.Count > 0)
            {
                DialogResult lkResult = MessageBox.Show("Máy tính đã được khai báo!\n Đồng chí có đồng ý cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (lkResult == DialogResult.Yes)
                {
                    if (dt_dvc4.Rows.Count > 0) {
                        Select_SQL.Update_Dm_Canbo(dt_dmcb.Rows[0]["MaCB"].ToString(), cb_dvc1.SelectedValue.ToString(), cb_dvc2.SelectedValue.ToString(), cb_dvc3.SelectedValue.ToString(), cb_dvc4.SelectedValue.ToString(), txt_hoten.Text, Environment.MachineName.ToString(), Connect_SQL.mac, txt_chucvu.Text, check_start.ToString()); Select_SQL.Load_Dm_Canbo(Connect_SQL.mac);
                    }
                    else if (dt_dvc3.Rows.Count > 0) {
                        Select_SQL.Update_Dm_CanboC3(dt_dmcb.Rows[0]["MaCB"].ToString(), cb_dvc1.SelectedValue.ToString(), cb_dvc2.SelectedValue.ToString(), cb_dvc3.SelectedValue.ToString(), txt_hoten.Text, Environment.MachineName.ToString(), Connect_SQL.mac, txt_chucvu.Text, check_start.ToString()); Select_SQL.Load_Dm_Canbo(Connect_SQL.mac);
                    }
                    else if (dt_dvc2.Rows.Count > 0)
                    {
                        Select_SQL.Update_Dm_CanboC2(dt_dmcb.Rows[0]["MaCB"].ToString(), cb_dvc1.SelectedValue.ToString(), cb_dvc2.SelectedValue.ToString(), txt_hoten.Text, Environment.MachineName.ToString(), Connect_SQL.mac, txt_chucvu.Text, check_start.ToString()); Select_SQL.Load_Dm_Canbo(Connect_SQL.mac);
                    }
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                if (dt_dvc4 != null) {
                    if (dt_dvc4.Rows.Count > 0 & dt_dvc3.Rows.Count > 0 & dt_dvc2.Rows.Count > 0 & dt_dvc1.Rows.Count > 0) { 
                    Select_SQL.Insert_Dm_Canbo(ID_Ma(), cb_dvc1.SelectedValue.ToString(), cb_dvc2.SelectedValue.ToString(), cb_dvc3.SelectedValue.ToString(), cb_dvc4.SelectedValue.ToString(), txt_hoten.Text, Environment.MachineName.ToString(), Connect_SQL.mac, txt_chucvu.Text, check_start.ToString());
                    }
                }
                else if (dt_dvc3 != null & dt_dvc3.Rows.Count > 0 & dt_dvc2.Rows.Count > 0 & dt_dvc1.Rows.Count > 0)
                {
                    Select_SQL.Insert_Dm_CanboC3(ID_Ma(), cb_dvc1.SelectedValue.ToString(), cb_dvc2.SelectedValue.ToString(), cb_dvc3.SelectedValue.ToString(), txt_hoten.Text, Environment.MachineName.ToString(), Connect_SQL.mac, txt_chucvu.Text, check_start.ToString());
                }
                else if (dt_dvc2 != null & dt_dvc2.Rows.Count > 0 & dt_dvc1.Rows.Count > 0)
                {
                    Select_SQL.Insert_Dm_CanboC2(ID_Ma(), cb_dvc1.SelectedValue.ToString(), cb_dvc2.SelectedValue.ToString(), txt_hoten.Text, Environment.MachineName.ToString(), Connect_SQL.mac, txt_chucvu.Text, check_start.ToString());
                }
                else if (dt_dvc1 != null & dt_dvc1.Rows.Count > 0)
                {
                    Select_SQL.Insert_Dm_CanboC1(ID_Ma(), cb_dvc1.SelectedValue.ToString(), txt_hoten.Text, Environment.MachineName.ToString(), Connect_SQL.mac, txt_chucvu.Text, check_start.ToString());
                }
                else { MessageBox.Show("Cập nhật thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question); }
                Select_SQL.Load_Dm_Canbo(Connect_SQL.mac);
                this.Hide();
                FrmHome frm_ = new FrmHome();
                frm_.ShowDialog();
            }
        }

        private void txt_chucvu_TextChanged(object sender, EventArgs e)
        {
            _btnOK.Enabled = true;
        }

        private void _cbStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (_cbStartWithWindows.Checked == true)
            {
                Startup.IsInStartup();
                Startup.RunOnStartup();
                check_start = true;
            }
            else { Startup.RemoveFromStartup(); check_start = false; }
        }
    }
}
