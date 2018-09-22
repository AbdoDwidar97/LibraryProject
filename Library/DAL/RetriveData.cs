using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Library.DAL
{
    class RetriveData
    {
        public static SqlConnection Con = new SqlConnection(DBConnect.Connection);

        public static DataTable ExcuteQuery(string text, CommandType ct)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = ct;
            com.CommandText = text;
            
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static DataTable ExcuteQuery(string text, CommandType ct,params Pararmter[] pararr)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = ct;
            com.CommandText = text;
            
            foreach (Pararmter prm in pararr)
            {
                com.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;
            }
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static void ExcuteNonQuery(string text,params Pararmter[] pararr)
        {
            Con.Open();
            
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = text;

            foreach (Pararmter prm in pararr)
            {
                com.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;
            }
            com.ExecuteNonQuery();
            Con.Close();

        }
        

    }

    public class Pararmter
    {
        public string pname;
        public SqlDbType pdtype;
        public object pvalue;

        public Pararmter(string pname, SqlDbType pdtype, object pvalue)
        {
            this.pname = pname;
            this.pdtype = pdtype;
            this.pvalue = pvalue;
        }
    }
}
