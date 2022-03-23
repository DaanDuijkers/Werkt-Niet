using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertInto.Classes
{
    class Bericht
    {
        Database database = new Database();

        private string boodschap;
        public string Boodschap { get { return boodschap; } set { boodschap = value; } }

        public void Insert()
        {
            database.Insert("INSERT INTO Boodschappen(Boodschap) VALUES('" + boodschap + "');");
            

            database.Insert("INSERT INTO Ontvangen(Ontvang, Tweede) VALUES((SELECT TOP 1 Boodschap FROM Boodschappen ORDER BY ID DESC),'" + boodschap + "')");
        }
    }
}
