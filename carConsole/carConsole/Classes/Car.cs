using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carConsole.Classes
{
    class Car
    {
        public string Make;
        public string Model;
        public decimal Price;

        public Car()
        {
            Make = "Empty";
            Model = "Empty";
            Price = 0.00M;
        }

        public Car(string setMake, string setModel, decimal setPrice)
        {
            Make = setMake;
            Model = setModel;
            Price = setPrice;
        }

        override public string ToString()
        {
            return "MAKE: " + Make + "; MODEL: " + Model + " PRICE: $" + Price.ToString();
        }
    }
}
