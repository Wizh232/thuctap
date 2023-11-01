using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace quanlykho.Utils
{
    internal class DBhelper
    {
        public static String serverName;
        public static String dbName;
        public static String userDb;
        public static String password;

        public static SqlConnection getConnection()
        {
            String strCnn = "Server=" + serverName + ";Database=" + dbName + ";User ID=" + userDb + ";Password=" + password; 
            return new SqlConnection(strCnn);
        }
    }
}
