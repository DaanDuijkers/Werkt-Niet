using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore.Classes
{
    class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (var boughtCar in ShoppingList)
            {
                totalCost += boughtCar.Price;
            }

            ShoppingList.Clear();
            return totalCost;
        }
    }
}
