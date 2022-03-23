using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes
{
    class Werkers
    {
        DatabaseInsert insertDatabase = new DatabaseInsert();
        DatabaseRead readDatabase = new DatabaseRead();

        protected string voornaam;
        public string Voornaam { get { return voornaam; } set { voornaam = value; } }
        protected string tussenvoegsel;
        public string Tussenvoegsel { get { return tussenvoegsel; } set { tussenvoegsel = value; } }
        protected string achternaam;
        public string Achternaam { get { return achternaam; } set { achternaam = value; } }
        protected string werkzaamheden;
        public string Werkzaamheden { get { return werkzaamheden; } set { werkzaamheden = value; } }
        protected DateTime beginTijd;
        public DateTime BeginTijd { get { return beginTijd; } set { beginTijd = value; } }
        protected DateTime eindTijd;
        public DateTime EindTijd { get { return eindTijd; } set { eindTijd = value; } }
        protected int dierentuinID;
        public int DierentuinID { get { return dierentuinID; } set { dierentuinID = value; } }

        public void Insert()
        {
            insertDatabase.Insert("INSERT INTO Werkers(Voornaam, Tussenvoegsel, Achternaam, Werkzaamheden, BeginTijd, EindTijd, DierentuinID) VALUES('" + Voornaam + "','" + Tussenvoegsel + "','" + Achternaam + "','" + Werkzaamheden + "','" + BeginTijd + "','" + EindTijd + "','" + DierentuinID + "');");
        }

        public DataTable View()
        {
            readDatabase.View("SELECT * FROM Werkers;");
            return readDatabase.dt;
        }
    }
}
