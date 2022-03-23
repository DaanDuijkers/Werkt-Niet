using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes
{
    class Dieren
    {
        DatabaseInsert insertDatabase = new DatabaseInsert();
        DatabaseRead readDatabase = new DatabaseRead();

        private string soort;
        public string Soort { get { return soort; } set { soort = value; } }
        private string naam;
        public string Naam { get { return naam; } set { naam = value; } }
        private string locatie;
        public string Locatie { get { return locatie; } set { locatie = value; } }
        private string eten;
        public string Eten { get { return eten; } set { eten = value; } }
        private string geslacht;
        public string Geslacht { get { return geslacht; } set { geslacht = value; } }
        private int dierentuinID;
        public int DierentuinID { get { return dierentuinID; } set { dierentuinID = value; } }

        public void Insert()
        {
            insertDatabase.Insert("INSERT INTO Dier(Naam, DierentuinID, Soort, Locatie, Eten, Geslacht) VALUES('" + Naam + "','" + DierentuinID + "','" + Soort + "','" + Locatie + "','" + Eten + "','" + Geslacht + "')");
        }

        public DataTable View()
        {
            readDatabase.View("SELECT * FROM Dier;");
            return readDatabase.dt;
        }

        public DataTable Filter(string soort)
        {
            string subQuery = "SELECT DierentuinID FROM Dier WHERE Soort ='" + soort + "'";
            readDatabase.Filter("SELECT Naam FROM Dierentuin WHERE ID IN (" + subQuery + ");");
            return readDatabase.dt;
        }
    }
}
