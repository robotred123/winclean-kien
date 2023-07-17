using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Clean_Recycle
{
    public class Auto_Policy
    {
        public static DataTable dt_startPolicy, dt_IdPolicy; private static List<string> ID_Policy = new List<string>();

        public static void start_auto()
        {
            Select_SQL.Load_StartPolicy(DateTime.Now.ToString("yyyy-MM-dd"));
            if (dt_startPolicy.Rows.Count > 0)
            {
                var ad = dt_startPolicy.Rows[0][0].ToString(); string[] ab = ad.Split(',', ' '); for (int a = 0; a < Convert.ToInt32(ab.Length / 1); a++) { if (ab[a] != "") { ID_Policy.Add(ab[a].ToString()); } }

                for (int i = 0; i < ID_Policy.Count; i++)
                {
                    Select_SQL.Load_AutoPolicy(ID_Policy[i].ToString());
                    Frm_Clean.xapth.Add(dt_IdPolicy.Rows[0]["Name_scripts"].ToString());
                    Frm_Clean.ma_Scrip.Add(dt_IdPolicy.Rows[0]["ID"].ToString());
                    Frm_Clean.time_start.Add(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                    Frm_Clean.count_.Add(dt_IdPolicy.Rows[0]["Name_scripts"].ToString());
                }
                Select_SQL.Load_xml();
            }
            time_satrt();
        }
        private static void time_satrt() { Thread.Sleep(21600000); start_auto(); }
    }
}
