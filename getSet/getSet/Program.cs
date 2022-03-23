using getSet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tom = new Person();
            Tom.getAge = -25;
            Console.WriteLine(Tom.getAge);
            Console.Read();
        }

    }
}
