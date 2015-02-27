using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BibliotecaClassLibrary.Data
{
    class Data_DBConnection
    {
        internal class DBConnection
        {
            protected SqlConnection conn;
            internal DBConnection(String str Conn);
        {
            conn = new SqlConnection(str Conn);
            conn.Open();
        }

        internal void Dispose()
        {
            conn.Close();
        }         
         
    }
}
