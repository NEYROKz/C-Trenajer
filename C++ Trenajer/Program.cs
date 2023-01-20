using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace C___Trenajer
{
    internal static class Program
    {
        

        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new authorization());
            

        }

        
    }

    public static class DataForm
    {
        public static int kz = 0;
        public static int grade1 = 0;
        public static int grade2 = 0;
        public static int grade3 = 0;
        public static int grade4 = 0;
        public static int allgrades = 0;

        public static string namez;
        public static string surnamez;
    }
 
}
