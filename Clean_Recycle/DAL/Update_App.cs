using AutoUpdaterDotNET;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Clean_Recycle
{
    public class Update_App
    {
        public static string version;

        #region Event update
        public static void version_()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            version = fvi.FileVersion;
        }

        public static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {
                DialogResult dialogResult;
                dialogResult =
                        MessageBox.Show("Phần mềm của bạn đã có phiên bản mới " + args.CurrentVersion + ".\nPhiên bản bạn đang sử dụng hiện tại " + args.InstalledVersion + ".\nBạn có muốn cập nhật phần mềm không?", "Cập nhật phần mềm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                {
                    try
                    {
                        if (AutoUpdater.DownloadUpdate(args))
                        {
                            Process[] workers = Process.GetProcessesByName("Clean_Recycle");
                            foreach (Process worker in workers)
                            {
                                worker.Kill();
                                worker.WaitForExit();
                                worker.Dispose();
                            }
                            Application.Exit();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            /*else
            {
                MessageBox.Show(@"Phiên bản bạn đang sử dụng đã được cập nhật mới nhất.", @"Cập nhật phần mềm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        #endregion
    }
}
