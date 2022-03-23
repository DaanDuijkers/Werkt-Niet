using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes
{
    class Verzorgers : Werkers
    {
        DatabaseInsert insertDatabase = new DatabaseInsert();
        DatabaseRead readDatabase = new DatabaseRead();

        private string dier;
        public string Dier { get { return dier; } set { dier = value; } }

        public new void Insert()
        {
            insertDatabase.Insert("INSERT INTO Werkers(Voornaam, Tussenvoegsel, Achternaam, Werkzaamheden, BeginTijd, EindTijd, DierentuinID) VALUES('" + Voornaam + "','" + Tussenvoegsel + "','" + Achternaam + "','" + Werkzaamheden + "','" + BeginTijd + "','" + EindTijd + "','" + DierentuinID + "');");

            insertDatabase.Insert("INSERT INTO Verzorger(WerkerID, DierSoort) VALUES((SELECT TOP 1 ID FROM Werkers ORDER BY ID DESC),'" + dier + "')");
        }

        public new DataTable View()
        {
            readDatabase.View("SELECT * FROM Verzorger;");
            return readDatabase.dt;
        }

        public DataTable Filter(int id)
        {
            readDatabase.Filter("SELECT DierSoort FROM Verzorger WHERE ID ='" + id + "';");
            return readDatabase.dt;
        }
    }
}
