using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes.Database
{
    class DatabaseRead : DatabaseConnect
    {
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void View(string query)
        {
            dt.Clear();
            da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            dt = ds.Tables[0];
        }

        public void Filter(string where)
        {
            dt.Clear();
            da = new SqlDataAdapter(where, con);
            da.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
