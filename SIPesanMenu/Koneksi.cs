using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//tambahkan namespace
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIPesanMenu
{
    class Koneksi
    {
        //deklarsi variabel
        private static string conn;

        static Koneksi()
        {
            string connStr = "Data Source=(local);" +
                "Initial Catalog=dbSIPesanMenu;" +
                "Integrited Security=True";
            conn = connStr;
        }

        public static SqlConnection Conn
        {
            get
            {
                return new SqlConnection(conn);
            }
        }
    }
}
