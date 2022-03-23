using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes
{
    class Dierentuinen
    {
        DatabaseInsert insertDatabase = new DatabaseInsert();
        DatabaseRead readDatabase = new DatabaseRead();

        private string naam;
        public string Naam { get { return naam; } set { naam = value; } }
        private string adres;
        public string Adres { get { return adres; } set { adres = value; } }
        private double budget;
        public double Budget { get { return budget; } set { budget = value; } }

        public void InsertDierentuinen()
        {
            insertDatabase.Insert("INSERT INTO dierentuin(Naam, Adres, Budget) VALUES('" + Naam + "','" + Adres + "','" + Budget + "')");
        }

        public DataTable View()
        {
            readDatabase.View("SELECT * FROM Dierentuin;");
            return readDatabase.dt;
        }

        public DataTable Filter(int id)
        {
            readDatabase.Filter("SELECT Naam FROM Dierentuin WHERE ID ='" + id + "';");
            return readDatabase.dt;
        }
    }
}
