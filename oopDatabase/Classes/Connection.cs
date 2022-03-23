using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopDatabase.Classes
{
    class Connection
    {
        public string ConString()
        {
            return @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;Initial Catalog=Dierentuin;Integrated Security=True";
        }

        public void Insert(string query)
        {
            SqlConnection con = new SqlConnection(ConString());
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
