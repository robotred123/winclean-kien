using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Clean_Recycle
{
    public class Startup
    {
        // Thêm tệp thực thi này vào danh sách khởi động.
        public static bool RunOnStartup()
        {
            return RunOnStartup(Application.ProductName, Application.ExecutablePath);
        }

        // Thêm tệp thực thi được chỉ định vào danh sách khởi động.
        /// <param name="AppTitle">Registry key title.</param>
        /// <param name="AppPath">Path of executable to run on startup.</param>
        public static bool RunOnStartup(string AppTitle, string AppPath)
        {
            RegistryKey rk;
            try
            {
                rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                rk.SetValue(AppTitle, AppPath);
                return true;
            }
            catch (Exception) { }

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                rk.SetValue(AppTitle, AppPath);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // Xóa tệp thực thi này khỏi danh sách khởi động.
        public static bool RemoveFromStartup()
        {
            return RemoveFromStartup(Application.ProductName, Application.ExecutablePath);
        }

        // Xóa tệp thực thi đã chỉ định khỏi danh sách khởi động.
        /// <param name="AppTitle">Registry key title.</param>
        /// <param name="AppPath">Path of executable in the registry that's being run on startup.</param>
        public static bool RemoveFromStartup(string AppTitle, string AppPath)
        {
            RegistryKey rk;
            try
            {
                rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (AppPath == null)
                {
                    rk.DeleteValue(AppTitle);
                }
                else
                {
                    if (rk.GetValue(AppTitle).ToString().ToLower() == AppPath.ToLower())
                    {
                        rk.DeleteValue(AppTitle);
                    }
                }
                return true;
            }
            catch (Exception) { }

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (AppPath == null)
                {
                    rk.DeleteValue(AppTitle);
                }
                else
                {
                    if (rk.GetValue(AppTitle).ToString().ToLower() == AppPath.ToLower())
                    {
                        rk.DeleteValue(AppTitle);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // Kiểm tra xem tệp thực thi này có trong danh sách khởi động không.
        public static bool IsInStartup()
        {
            return IsInStartup(Application.ProductName, Application.ExecutablePath);
        }

        // Kiểm tra xem tệp thực thi được chỉ định có trong danh sách khởi động không.
        /// <param name="AppTitle">Registry key title.</param>
        /// <param name="AppPath">Path of the executable.</param>
        /// <returns></returns>
        public static bool IsInStartup(string AppTitle, string AppPath)
        {
            RegistryKey rk;
            string value;

            try
            {
                rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                value = rk.GetValue(AppTitle).ToString();
                if (value == null)
                {
                    return false;
                }
                else if (!value.ToLower().Equals(AppPath.ToLower()))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception) { }

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                value = rk.GetValue(AppTitle).ToString();
                if (value == null)
                {
                    return false;
                }
                else if (!value.ToLower().Equals(AppPath.ToLower()))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception) { }
            return false;
        }
    }
}
