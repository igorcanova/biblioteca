using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaClassLibrary.Data
{
    class CategoriaData
    {
        internal class CategoriaData : DBConnection
        {
            internal CategoriaData(string str Conn):base(strConn){}
            internal void Create(Categoria e)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
            }
        }

    }
}
