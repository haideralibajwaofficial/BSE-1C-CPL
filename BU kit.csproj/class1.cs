using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BU_Kit
{
    public static class appConfig
    {
        public static string mainDir = "App Files";
        public static string dbPath = Path.Combine(mainDir, "db.txt");
        public static string newEntry = "x==.==.==.==.==.==.==x";
        public static string[] data = null;
        public static string sender = "haiderali22006@gmail.com";
        public static string lastUidPath;
        public static string errorLogPath = Path.Combine(mainDir, "error.log");

        public static void setuid()
        {
            lastUidPath = menu.get(menu.enroll, "firstname") + "lastUid.txt";
        }


        public static string[,] campusRooms = { { "E-102", "Q-204", "I-503", null }, { "J-120", "N-210", "Q-404", "S-312"} }; 
    }
}
