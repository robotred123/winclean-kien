using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Clean_Recycle
{
    public class Select_SQL
    {
        #region Create Dll
        private static SqlConnection conn = Connect_SQL.GetConnetion();
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter da = new SqlDataAdapter();
        public static DataTable dt, dt_Details_Clean, dt_Log_Status;
        #endregion

        #region Load_Dm_Donvi
        // Don vi cap 1
        public static void Dv_cap1()
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Select_Dv_cap1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); Frm_Dm_CB.dt_dvc1 = dt; } catch (Exception ex) { }
                conn.Close();
            }
        }
        // Don vi cap 2
        public static void Dv_cap2(string Units_c1)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Select_Dv_cap2", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Units_c1", Units_c1));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt);
                    int i = dt.Rows.Count;
                    if (dt.Rows.Count > 0)
                    {
                        DataRow emptyRow = dt.NewRow();
                        dt.Rows.InsertAt(emptyRow, i);
                    }
                    Frm_Dm_CB.dt_dvc2 = dt; } catch (Exception ex) { }
                conn.Close();
            }
        }
        // Don vi cap 3
        public static void Dv_cap3(string Units_c2)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Select_Dv_cap3", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Units_c2", Units_c2));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt);
                    int i = dt.Rows.Count;
                    if (dt.Rows.Count > 0)
                    {
                        DataRow emptyRow = dt.NewRow();
                        dt.Rows.InsertAt(emptyRow, i);
                    }
                    Frm_Dm_CB.dt_dvc3 = dt; } catch (Exception ex) { }
                conn.Close();
            }
        }
        // Don vi cap 4
        public static void Dv_cap4(string Units_c3)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Select_Dv_cap4", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Units_c3", Units_c3));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt);
                    int i = dt.Rows.Count;
                    if (dt.Rows.Count > 0) {
                        DataRow emptyRow = dt.NewRow();
                        dt.Rows.InsertAt(emptyRow, i);
                    }
                Frm_Dm_CB.dt_dvc4 = dt; } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Load_Policy
        public static void Load_Policy()
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Policy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
                Frm_Clean.dt_Policy = dt;
            }
        }
        #endregion

        #region Load_BasicPolicy
        public static void Load_BasicPolicy()
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_BasicPolicy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
                FrmHome.dt_BasicPolicy = dt;
            }
        }
        #endregion

        #region Load_MaCB
        public static void Load_MaCB()
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Select_Ma_Canbo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close(); Frm_Dm_CB.dt_Macb = dt;
            }
        }
        #endregion

        #region Load_Dm_Canbo
        public static void Load_Dm_Canbo(string MAC)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Select_Dm_Canbo_New", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); Frm_Dm_CB.dt_dmcb = dt; } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Load_Details_Clean
        public static void Load_Details_Clean(string MAC, string Details_ID)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_select_Details_Clean", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Details_ID", Details_ID));
                cmd.Parameters.Add(new SqlParameter("@ngayup", DateTime.Now.ToString("yyyy-MM-dd")));
                da = new SqlDataAdapter(cmd); dt_Details_Clean = new DataTable();
                try { da.Fill(dt_Details_Clean); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Load_Log_Status
        public static void Load_Log_Status(string Status_ID, string Ma)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_select_Log_Status", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Status_ID", Status_ID));
                cmd.Parameters.Add(new SqlParameter("@Ma", Ma));
                da = new SqlDataAdapter(cmd); dt_Log_Status = new DataTable();
                try { da.Fill(dt_Log_Status); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Load_Start_Policy
        public static void Load_StartPolicy(string ngayup)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Select_Start_Policy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@date_start", ngayup));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); Auto_Policy.dt_startPolicy = dt; } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Load_Auto_Policy
        public static void Load_AutoPolicy(string ID_policy)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Auto_Policy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID_policy));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); Auto_Policy.dt_IdPolicy = dt; } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Insert_Dm_Canbo
        public static void Insert_Dm_Canbo(string MaCB, string Units_c1, string Units_c2, string Units_c3, string Units_c4, string Hoten, string Computer_name, string MAC, string Position, string Auto_Start)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_insert_Dm_Canbo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@Units_c1", Units_c1));
                cmd.Parameters.Add(new SqlParameter("@Units_c2", Units_c2));
                cmd.Parameters.Add(new SqlParameter("@Units_c3", Units_c3));
                cmd.Parameters.Add(new SqlParameter("@Units_c4", Units_c4));
                cmd.Parameters.Add(new SqlParameter("@Hoten", Hoten));
                cmd.Parameters.Add(new SqlParameter("@Computer_name", Computer_name));
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Position", Position));
                cmd.Parameters.Add(new SqlParameter("@Auto_start", Auto_Start));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question); } catch (Exception ex) { }
                conn.Close();
            }
        }

        public static void Insert_Dm_CanboC3(string MaCB, string Units_c1, string Units_c2, string Units_c3, string Hoten, string Computer_name, string MAC, string Position, string Auto_Start)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_insert_Dm_Canbo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@Units_c1", Units_c1));
                cmd.Parameters.Add(new SqlParameter("@Units_c2", Units_c2));
                cmd.Parameters.Add(new SqlParameter("@Units_c3", Units_c3));
                cmd.Parameters.Add(new SqlParameter("@Units_c4", ""));
                cmd.Parameters.Add(new SqlParameter("@Hoten", Hoten));
                cmd.Parameters.Add(new SqlParameter("@Computer_name", Computer_name));
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Position", Position));
                cmd.Parameters.Add(new SqlParameter("@Auto_start", Auto_Start));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question); } catch (Exception ex) { }
                conn.Close();
            }
        }

        public static void Insert_Dm_CanboC2(string MaCB, string Units_c1, string Units_c2, string Hoten, string Computer_name, string MAC, string Position, string Auto_Start)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_insert_Dm_Canbo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@Units_c1", Units_c1));
                cmd.Parameters.Add(new SqlParameter("@Units_c2", Units_c2));
                cmd.Parameters.Add(new SqlParameter("@Units_c3", ""));
                cmd.Parameters.Add(new SqlParameter("@Units_c4", ""));
                cmd.Parameters.Add(new SqlParameter("@Hoten", Hoten));
                cmd.Parameters.Add(new SqlParameter("@Computer_name", Computer_name));
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Position", Position));
                cmd.Parameters.Add(new SqlParameter("@Auto_start", Auto_Start));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question); } catch (Exception ex) { }
                conn.Close();
            }
        }
        public static void Insert_Dm_CanboC1(string MaCB, string Units_c1, string Hoten, string Computer_name, string MAC, string Position, string Auto_Start)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_insert_Dm_Canbo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@Units_c1", Units_c1));
                cmd.Parameters.Add(new SqlParameter("@Units_c2", ""));
                cmd.Parameters.Add(new SqlParameter("@Units_c3", ""));
                cmd.Parameters.Add(new SqlParameter("@Units_c4", ""));
                cmd.Parameters.Add(new SqlParameter("@Hoten", Hoten));
                cmd.Parameters.Add(new SqlParameter("@Computer_name", Computer_name));
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Position", Position));
                cmd.Parameters.Add(new SqlParameter("@Auto_start", Auto_Start));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Update_Dm_Canbo
        public static void Update_Dm_Canbo(string MaCB, string Units_c1, string Units_c2, string Units_c3, string Units_c4, string Hoten, string Computer_name, string MAC, string Position, string Auto_Start)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Update_Dm_Canbo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@Units_c1", Units_c1));
                cmd.Parameters.Add(new SqlParameter("@Units_c2", Units_c2));
                cmd.Parameters.Add(new SqlParameter("@Units_c3", Units_c3));
                cmd.Parameters.Add(new SqlParameter("@Units_c4", Units_c4));
                cmd.Parameters.Add(new SqlParameter("@Hoten", Hoten));
                cmd.Parameters.Add(new SqlParameter("@Computer_name", Computer_name));
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Position", Position));
                cmd.Parameters.Add(new SqlParameter("@Auto_start", Auto_Start));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }

        public static void Update_Dm_CanboC3(string MaCB, string Units_c1, string Units_c2, string Units_c3, string Hoten, string Computer_name, string MAC, string Position, string Auto_Start)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Update_Dm_Canbo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@Units_c1", Units_c1));
                cmd.Parameters.Add(new SqlParameter("@Units_c2", Units_c2));
                cmd.Parameters.Add(new SqlParameter("@Units_c3", Units_c3));
                cmd.Parameters.Add(new SqlParameter("@Units_c4", ""));
                cmd.Parameters.Add(new SqlParameter("@Hoten", Hoten));
                cmd.Parameters.Add(new SqlParameter("@Computer_name", Computer_name));
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Position", Position));
                cmd.Parameters.Add(new SqlParameter("@Auto_start", Auto_Start));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }

        public static void Update_Dm_CanboC2(string MaCB, string Units_c1, string Units_c2, string Hoten, string Computer_name, string MAC, string Position, string Auto_Start)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Update_Dm_Canbo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@Units_c1", Units_c1));
                cmd.Parameters.Add(new SqlParameter("@Units_c2", Units_c2));
                cmd.Parameters.Add(new SqlParameter("@Units_c3", ""));
                cmd.Parameters.Add(new SqlParameter("@Units_c4", ""));
                cmd.Parameters.Add(new SqlParameter("@Hoten", Hoten));
                cmd.Parameters.Add(new SqlParameter("@Computer_name", Computer_name));
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Position", Position));
                cmd.Parameters.Add(new SqlParameter("@Auto_start", Auto_Start));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Insert_Details_Clean
        public static void Insert_Details_Clean(string MAC, string Details_ID, string Time_Implement, string Time_Stop)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_insert_Details_Clean", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Details_ID", Details_ID));
                cmd.Parameters.Add(new SqlParameter("@Time_Implement", Time_Implement));
                cmd.Parameters.Add(new SqlParameter("@Time_Stop", Time_Stop));
                cmd.Parameters.Add(new SqlParameter("@ngayup", DateTime.Now.ToString("yyyy-MM-dd")));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Update_Details_Clean
        public static void Update_Details_Clean(string MAC, string Details_ID, string Time_Implement, string Time_Stop)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Update_Details_Clean", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAC", MAC));
                cmd.Parameters.Add(new SqlParameter("@Details_ID", Details_ID));
                cmd.Parameters.Add(new SqlParameter("@Time_Implement", Time_Implement));
                cmd.Parameters.Add(new SqlParameter("@Time_Stop", Time_Stop));
                cmd.Parameters.Add(new SqlParameter("@ngayup", DateTime.Now.ToString("yyyy-MM-dd")));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Insert_Log_Status
        public static void Insert_Log_Status(string Status_ID, string Details, string Ma_DtClean, string Trangthai)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_insert_Log_Status", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Status_ID", Status_ID));
                cmd.Parameters.Add(new SqlParameter("@Details", Details));
                cmd.Parameters.Add(new SqlParameter("@Ma", Ma_DtClean));
                cmd.Parameters.Add(new SqlParameter("@Trangthai", Trangthai));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Update_Log_Status
        public static void Update_Log_Status(string ID, string Status_ID, string Details, string Ma_DtClean, string Trangthai)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Update_Log_Status", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@Status_ID", Status_ID));
                cmd.Parameters.Add(new SqlParameter("@Details", Details));
                cmd.Parameters.Add(new SqlParameter("@Ma", Ma_DtClean));
                cmd.Parameters.Add(new SqlParameter("@Trangthai", Trangthai));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Insert_Log_Keytest
        public static void Insert_Log_Keytest(string MaCB, string Date_test, string Trangthai)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_insert_Log_Keytest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@date_test", DateTime.Now.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("@status", Trangthai));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion

        #region Update_Log_Keytest
        public static void Update_Log_Keytest(string ID, string MaCB, string Date_test, string Trangthai)
        {
            if (conn.State.ToString() == "Closed") { conn = Connect_SQL.GetConnetion(); }
            using (conn)
            {
                cmd = new SqlCommand("sp_Update_Log_KeyTest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@MaCB", MaCB));
                cmd.Parameters.Add(new SqlParameter("@date_test", DateTime.Now.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("@status", Trangthai));
                da = new SqlDataAdapter(cmd); dt = new DataTable();
                try { da.Fill(dt); } catch (Exception ex) { }
                conn.Close();
            }
        }
        #endregion


        #region Open Xml
        public static void Load_xml()
        {
            for(int a = 0; a < Frm_Clean.count_.Count; a++)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode; XmlNodeList xmlnode2; XmlNodeList xmlnode3;
                string filePath = AppDomain.CurrentDomain.BaseDirectory;
                string file = filePath + "Scripts\\" + Frm_Clean.xapth[a] + ".xml";
                if (!File.Exists(file))
                {
                    MessageBox.Show("Không tìm thấy file " + Frm_Clean.xapth[a] + "!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FileStream fs = new FileStream("Scripts\\" + Frm_Clean.xapth[a] + ".xml", FileMode.Open, FileAccess.Read);
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("Host");
                    xmlnode3 = xmldoc.GetElementsByTagName("Name");
                    // Get data Host
                    xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    string str = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    // Get data Name
                    xmlnode3[0].ChildNodes.Item(0).InnerText.Trim();
                    string str3 = xmlnode3[0].ChildNodes.Item(0).InnerText.Trim();
                    // get data code
                    xmlnode2 = xmldoc.GetElementsByTagName("Code");
                    xmlnode2[0].ChildNodes.Item(0).InnerText.Trim();
                    string str2 = xmlnode2[0].ChildNodes.Item(0).InnerText.Trim();
                    Run_Scripts.Run_Code(str, str2, str3, a);
                }
            }
        }

        public static void Load_Basicxml()
        {
            for (int a = 0; a < FrmHome.count_.Count; a++)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode; XmlNodeList xmlnode2; XmlNodeList xmlnode3;
                string filePath = AppDomain.CurrentDomain.BaseDirectory;
                string file = filePath + "Scripts\\" + FrmHome.xapth[a] + ".xml";
                if (!File.Exists(file))
                {
                    MessageBox.Show("Không tìm thấy file " + FrmHome.xapth[a] + "!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FileStream fs = new FileStream("Scripts\\" + FrmHome.xapth[a] + ".xml", FileMode.Open, FileAccess.Read);
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("Host");
                    xmlnode3 = xmldoc.GetElementsByTagName("Name");
                    // Get data Host
                    xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    string str = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                    // Get data Name
                    xmlnode3[0].ChildNodes.Item(0).InnerText.Trim();
                    string str3 = xmlnode3[0].ChildNodes.Item(0).InnerText.Trim();
                    // get data code
                    xmlnode2 = xmldoc.GetElementsByTagName("Code");
                    xmlnode2[0].ChildNodes.Item(0).InnerText.Trim();
                    string str2 = xmlnode2[0].ChildNodes.Item(0).InnerText.Trim();
                    Run_Scripts.Run_CodeBasic(str, str2, str3, a);
/*                    Run_Scripts.Run_CMD(str2);*/
                }
            }
        }
        #endregion
    }
}
