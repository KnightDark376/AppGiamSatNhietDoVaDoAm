using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class ConnectDB
    {
        private OleDbConnection myConnection = new OleDbConnection();

        public OleDbConnection MyConnection { get => myConnection; set => myConnection = value; }

        public void Connect()
        {

            try
            {
                myConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0 ; Data Source=DB.mdb";
                myConnection.Open();
            }
            catch (Exception)
            {
            }

        }



        public OleDbDataReader SelectSQL(String sql)
        {
            OleDbCommand cmd = MyConnection.CreateCommand();
            cmd.CommandText = sql;
            OleDbDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();
            return reader;
        }


        public int UpdateSQL(String sql)
        {
            OleDbCommand cmd = MyConnection.CreateCommand();
            cmd.CommandText = sql;
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }


        public void Close()
        {
            try
            {
                if (MyConnection != null && MyConnection.State == ConnectionState.Open)
                {
                    MyConnection.Close();
                }
            }
            catch { }
        }
    }
}
