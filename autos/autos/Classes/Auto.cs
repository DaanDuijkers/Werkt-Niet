using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static autos.Program;

namespace autos.Classes
{
    class Auto
    {
        private int kmStand = 0;
        public int KmStand
        {
            get { return kmStand; }
        }
        
        public readonly string Kenteken;
        


        public int RijdKilomets (int _RijdKilomets)
        {
            if (kmStand >= 0)
            {
                kmStand = kmStand + _RijdKilomets;
            }

            return kmStand;
        }


        public void Brandstof()
        {

        }


    }
}
