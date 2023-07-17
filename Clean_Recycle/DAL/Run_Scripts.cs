using System;
using System.Diagnostics;
using System.Text;

namespace Clean_Recycle
{
    public class Run_Scripts
    {
        public static void Run_CMD(string scripts)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "cmd.exe";
            startInfo.Verb = "runas";
            startInfo.Arguments = "/user:Administrator \"cmd /K " + scripts + "\"";
            var cmd = new Process();
            cmd.StartInfo = startInfo;
            var output = new StringBuilder();
            // trình xử lý đầu ra
            cmd.OutputDataReceived += (sender, args) => output.AppendLine(args.Data);
            string stdError = "";

            try
            {
                cmd.Start();
                // nhận đầu ra tiêu chuẩn không đồng bộ
                cmd.BeginOutputReadLine();
                // nhận lỗi tiêu chuẩn đồng bộ
                stdError = cmd.StandardError.ReadToEnd();
                cmd.WaitForExit();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi hệ điều hành khi thực thi: " + e.Message);
            }

            if (cmd.ExitCode != 0)
            {
                throw new Exception("Đã hoàn tất với mã = " + cmd.ExitCode + ": " + stdError);
            }
            string stdOut = output.ToString();
        }

        public static void Run_PowerShell(string scripts)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "powershell.exe";
            startInfo.Verb = "runas"; startInfo.Arguments = "/user:Administrator \"cmd /K " + scripts + "\"";
            var cmd = new Process();
            cmd.StartInfo = startInfo;
            var output = new StringBuilder();
            // trình xử lý đầu ra
            cmd.OutputDataReceived += (sender, args) => output.AppendLine(args.Data);
            string stdError = "";

            try
            {
                cmd.Start();
                // nhận đầu ra tiêu chuẩn không đồng bộ
                cmd.BeginOutputReadLine();
                // nhận lỗi tiêu chuẩn đồng bộ
                stdError = cmd.StandardError.ReadToEnd();
                cmd.WaitForExit();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi hệ điều hành khi thực thi: " + e.Message);
            }

            if (cmd.ExitCode != 0)
            {
                throw new Exception("Đã hoàn tất với mã = " + cmd.ExitCode + ": " + stdError);
            }
            string stdOut = output.ToString();
        }

        public static void Run_Regedit(string scripts)
        {
            Process regeditProcess = new Process();
            regeditProcess = Process.Start("reg.exe", "/s \"" + scripts + "\"");
            regeditProcess.WaitForExit();
        }

        public static void Run_Code(string host, string scripts, string Name, int s)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = host + ".exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            //startInfo.Verb = "runas";
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            var cmd = new Process();
            cmd.StartInfo = startInfo;
            var output = new StringBuilder();
            // trình xử lý đầu ra
            cmd.OutputDataReceived += (sender, args) => output.AppendLine(args.Data);
            string stdError = "";
            try
            {
                cmd.Start();
                cmd.StandardInput.WriteLine(scripts);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                // nhận đầu ra tiêu chuẩn không đồng bộ
                cmd.BeginOutputReadLine();
                // nhận lỗi tiêu chuẩn đồng bộ
                stdError = cmd.StandardError.ReadToEnd();
                cmd.WaitForExit();
            }
            catch (Exception e)
            {
                Select_SQL.Load_Details_Clean(Connect_SQL.mac, Frm_Clean.ma_Scrip[s]);
                if (Select_SQL.dt_Details_Clean.Rows.Count > 0)
                {
                    Select_SQL.Update_Details_Clean(Connect_SQL.mac, Frm_Clean.ma_Scrip[s], Frm_Clean.time_start[s], DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                }
                else
                {
                    Select_SQL.Insert_Details_Clean(Connect_SQL.mac, Frm_Clean.ma_Scrip[s], Frm_Clean.time_start[s], DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                }

                Select_SQL.Load_Log_Status(Frm_Clean.ma_Scrip[s], Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString());
                if (Select_SQL.dt_Log_Status.Rows.Count > 0)
                {
                    Select_SQL.Update_Log_Status(Select_SQL.dt_Log_Status.Rows[0]["ID"].ToString(), Frm_Clean.ma_Scrip[s], stdError, Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString(), "Thực thi thành công");
                }
                else
                {

                    Select_SQL.Insert_Log_Status(Frm_Clean.ma_Scrip[s], stdError, Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString(), "Lỗi thực thi");
                }
                Frm_Clean.thongbao_hile = "Lỗi thực hiện với " + Name;
            }

            if (cmd.ExitCode == 0)
            {
                Select_SQL.Load_Details_Clean(Connect_SQL.mac, Frm_Clean.ma_Scrip[s]);
                if (Select_SQL.dt_Details_Clean.Rows.Count > 0)
                {
                    Select_SQL.Update_Details_Clean(Connect_SQL.mac, Frm_Clean.ma_Scrip[s], Frm_Clean.time_start[s], DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                }
                else
                {
                    Select_SQL.Insert_Details_Clean(Connect_SQL.mac, Frm_Clean.ma_Scrip[s], Frm_Clean.time_start[s], DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                    Select_SQL.Load_Details_Clean(Connect_SQL.mac, Frm_Clean.ma_Scrip[s]);
                }

                Select_SQL.Load_Log_Status(Frm_Clean.ma_Scrip[s], Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString());
                if (Select_SQL.dt_Log_Status.Rows.Count > 0)
                {
                    Select_SQL.Update_Log_Status(Select_SQL.dt_Log_Status.Rows[0]["ID"].ToString(), Frm_Clean.ma_Scrip[s], stdError, Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString(), "Thực thi thành công");
                }
                else
                {

                    Select_SQL.Insert_Log_Status(Frm_Clean.ma_Scrip[s], stdError, Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString(), "Thực thi thành công");
                }
                Frm_Clean.thongbao_hile = "Đã hoàn tất với " + Name;
            }
            Frm_AlertBox.Name_scriptc = Name;
            Frm_Clean.check_();
        }
        public static void Run_CodeBasic(string host, string scripts, string Name, int s)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = host + ".exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            //startInfo.Verb = "runas";
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            var cmd = new Process();
            cmd.StartInfo = startInfo;
            var output = new StringBuilder();
            // trình xử lý đầu ra
            cmd.OutputDataReceived += (sender, args) => output.AppendLine(args.Data);
            string stdError = "";
            try
            {
                cmd.Start();
                cmd.StandardInput.WriteLine(scripts);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                // nhận đầu ra tiêu chuẩn không đồng bộ
                cmd.BeginOutputReadLine();
                // nhận lỗi tiêu chuẩn đồng bộ
                stdError = cmd.StandardError.ReadToEnd();
                cmd.WaitForExit();
            }
            catch (Exception e)
            {
                Select_SQL.Load_Details_Clean(Connect_SQL.mac, FrmHome.ma_Scrip[s]);
                if (Select_SQL.dt_Details_Clean.Rows.Count > 0)
                {
                    Select_SQL.Update_Details_Clean(Connect_SQL.mac, FrmHome.ma_Scrip[s], FrmHome.time_start[s], DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                }
                else
                {
                    Select_SQL.Insert_Details_Clean(Connect_SQL.mac, FrmHome.ma_Scrip[s], FrmHome.time_start[s], DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                }

                Select_SQL.Load_Log_Status(FrmHome.ma_Scrip[s], Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString());
                if (Select_SQL.dt_Log_Status.Rows.Count > 0)
                {
                    Select_SQL.Update_Log_Status(Select_SQL.dt_Log_Status.Rows[0]["ID"].ToString(), FrmHome.ma_Scrip[s], stdError, Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString(), "Thực thi thành công");
                }
                else
                {

                    Select_SQL.Insert_Log_Status(FrmHome.ma_Scrip[s], stdError, Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString(), "Lỗi thực thi");
                }
                FrmHome.thongbao_hile = "Lỗi thực hiện với " + Name;
            }

            if (cmd.ExitCode == 0)
            {
                Select_SQL.Load_Details_Clean(Connect_SQL.mac, FrmHome.ma_Scrip[s]);
                if (Select_SQL.dt_Details_Clean.Rows.Count > 0)
                {
                    Select_SQL.Update_Details_Clean(Connect_SQL.mac, FrmHome.ma_Scrip[s], FrmHome.time_start[s], DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                }
                else
                {
                    Select_SQL.Insert_Details_Clean(Connect_SQL.mac, FrmHome.ma_Scrip[s], FrmHome.time_start[s], DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                    Select_SQL.Load_Details_Clean(Connect_SQL.mac, FrmHome.ma_Scrip[s]);
                }

                Select_SQL.Load_Log_Status(FrmHome.ma_Scrip[s], Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString());
                if (Select_SQL.dt_Log_Status.Rows.Count > 0)
                {
                    Select_SQL.Update_Log_Status(Select_SQL.dt_Log_Status.Rows[0]["ID"].ToString(), FrmHome.ma_Scrip[s], stdError, Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString(), "Thực thi thành công");
                }
                else
                {

                    Select_SQL.Insert_Log_Status(FrmHome.ma_Scrip[s], stdError, Select_SQL.dt_Details_Clean.Rows[0]["Ma"].ToString(), "Thực thi thành công");
                }
                FrmHome.thongbao_hile = "Đã hoàn tất với " + Name;
            }
            Frm_AlertBox.Name_scriptc = Name;
            FrmHome.check_();
        }
    }
}
