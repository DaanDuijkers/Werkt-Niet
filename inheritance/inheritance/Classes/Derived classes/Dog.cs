using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Classes.Derived_classes
{
    class Dog : Animal
    {
        public int spotCount;

        public void printBase()
        {
            Animal animal = new Animal();
            animal.printBase();
            Console.WriteLine("Spot Count: " + spotCount);
        }
    }
}
