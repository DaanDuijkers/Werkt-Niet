using inheritance.Classes.Derived_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog spotty = new Dog ();

            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.printBase ();

            Console.ReadKey ();
        }
    }
}
