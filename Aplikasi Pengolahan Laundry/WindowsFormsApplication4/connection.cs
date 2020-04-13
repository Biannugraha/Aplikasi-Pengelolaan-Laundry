using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


    namespace WindowsFormsApplication4
{
    public static class connection
    {
        public static String con = @"Data Source=DESKTOP-U9UPF9T;Initial Catalog=Aplikasi_Laundry;Integrated Security=True";
        public static SqlConnection log = new SqlConnection(@"Data Source=DESKTOP-U9UPF9T;Initial Catalog=Aplikasi_Laundry;Integrated Security=True");
        public static string username = "";
    }
}
