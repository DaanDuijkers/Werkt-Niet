using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierentuinAdmin.Classes
{
    class Dierentuin
    {
        DatabaseRead reader = new DatabaseRead();

        private string where;
        public string Where { get { return where; } set { where = value; } }

        public DataTable ViewDierentuin ()
        {
            reader.GridviewData("SELECT * FROM Dierentuinen");
            return reader.dt;
        }

        public DataTable SelectDierentuin (string where)
        {
            reader.Filter(where);
            return reader.dt;
        }
    }
}
