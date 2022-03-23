using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet.Classes
{
    class Person
    {
        private int age;
        public int getAge { get { return age; } set { if (value >= 0) { age = value; } } }
    }
}
