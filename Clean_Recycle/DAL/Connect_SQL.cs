using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Clean_Recycle
{
    public class Connect_SQL
    {
        #region Create Dll
        public static string mac, ipaddress, strComputerName, strNameUser;
        private static SqlConnection con;
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter da = new SqlDataAdapter();
        #endregion

        #region Connect SQL
        public static SqlConnection GetConnetion()
        {
            string StrCon = ConfigurationManager.ConnectionStrings["connectSQL"].ToString();
            con = new SqlConnection(StrCon);
            return con;
        }

        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = con;
            if (conn.State == ConnectionState.Closed)
            {
                conn = Connect_SQL.GetConnetion();
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            conn.Close();
        }
        #endregion

        #region Get IP and MAC
        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipaddress = ip.ToString();
                }
            }
            return null;
        }

        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                var addr = nic.GetIPProperties().GatewayAddresses.FirstOrDefault();
                if (addr != null) { 
                    if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet && nic.OperationalStatus == OperationalStatus.Up)
                    {
                        mac = string.Join("-", (from z in nic.GetPhysicalAddress().GetAddressBytes() select z.ToString("X2")).ToArray());
                        foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                ipaddress = ip.Address.ToString();
                            }
                        }
                        //GetLocalIPAddress();
                    }
                }
            }
            return null;
        }
        #endregion
    }
}
