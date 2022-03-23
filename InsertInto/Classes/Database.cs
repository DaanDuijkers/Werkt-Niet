using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertInto.Classes
{
    class Database
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog=InsertInto;
            Integrated Security=True");
        SqlCommand cmd;

        public void Insert(string query)
        {
            con.Open();

            cmd = new SqlCommand(query,
                con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
