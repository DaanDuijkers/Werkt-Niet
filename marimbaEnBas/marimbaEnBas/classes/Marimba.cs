using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marimbaEnBas
{
    class Marimba
    {
        private string note;

        public void PlayNote(string _note)
        {
            note = _note;

            Console.WriteLine("Marimba note: " + note);
        }
    }
}
