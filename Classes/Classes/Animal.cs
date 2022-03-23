using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Animal
    {
        // CLASS VARIABLES

        public static int count = 0;

        private string name;
        private int age;
        private float happiness;

        // CLASS CONTRUCTORS

        public Animal()
        {
            name = "Spotty";
            age = 6;
            happiness = 0.5f;

            count++;
        }

        public Animal (string _name, int _age, float _happiness)
        {
            name = _name;
            age = _age;
            happiness = _happiness;

            count++;
        }

        // CLASS METHODS

        public void Print()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("happiness: " + happiness);
        }
    }
}