using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Library.DAL
{
    class DBConnect
    {
        public static string Connection = ConfigurationManager.ConnectionStrings["Library.Properties.Settings.LibraryConnectionString"].ConnectionString;

        public static SqlConnection Conn = new SqlConnection(Connection);
         
                
        public SqlCommand Comm = new SqlCommand();

        public DBConnect()
        {
            OpenConnection();
        }


        void OpenConnection()
        {

            if(Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }


        }



    }



}
