using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierentuinAdmin.Classes
{
    class DatabaseRead : DatabaseConnect
    {
        public List<string> dataFill = new List<string>();

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void ComboboxData(string query)
        {
            dataFill.Clear();

            dataFill.Add("---- SELECT ----");
            using (cmd = new SqlCommand())
            {
                con.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataFill.Add(rdr[1].ToString());
                }
                con.Close();
            }
        }

        public void GridviewData(string query)
        {
            dt.Clear();
            da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            dt = ds.Tables[0];
        }

        public void Filter(string where)
        {
            dt.Clear();
            string queryFilter = "SELECT * FROM Dierentuinen WHERE Naam ='" + where + "';";
            da = new SqlDataAdapter(queryFilter, con);
            da.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
