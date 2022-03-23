using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();

            Console.WriteLine();

            Animal cat = new Animal("Mr. Beans", 10, 0.8f);
            cat.Print();

            Console.WriteLine();
            Console.WriteLine("Num of animals: " + Animal.count);

            Console.ReadKey();
        }
    }
}