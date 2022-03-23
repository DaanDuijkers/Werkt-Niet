using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes.Database
{
    class DatabaseInsert : DatabaseConnect
    {
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
