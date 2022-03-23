using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marimbaEnBas.classes
{
    class BassGuitar
    {
        private string note;

        public void PlayNote(string _note)
        {
            note = _note;

            Console.WriteLine("Bass note: " + note);
        }
    }
}
