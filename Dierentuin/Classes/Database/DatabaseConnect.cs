using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes.Database
{
    class DatabaseConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog=Dierentuin;
            Integrated Security=True");
        protected SqlCommand cmd;
        protected SqlDataAdapter da;
    }
}
