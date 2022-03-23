using carStore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carStore
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car c = new Car(txbMake.Text, txbModel.Text, Convert.ToDecimal(txbPrice.Text));
                myStore.CarList.Add(c);
                carInventoryBindingSource.ResetBindings(false);

                empty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void printInvertory (Store s)
        {
            foreach (Car c in s.CarList)
            {
                Console.WriteLine("Car: " + c.Make + " Model: " + c.Model + " Price: €" + c.Price);
            }
        }

        private void empty()
        {
            txbMake.Text = string.Empty;
            txbModel.Text = string.Empty;
            txbPrice.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car selected = (Car)lbInventory.SelectedItem;
            myStore.ShoppingList.Add(selected);
            cartBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;
            cartBindingSource.DataSource = myStore.ShoppingList;

            lbInventory.DataSource = carInventoryBindingSource;
            lbCart.DataSource = cartBindingSource;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal totalPrice = myStore.Checkout();
            lblTotalPrice.Text = "€" + totalPrice.ToString(".00");
            cartBindingSource.ResetBindings(false);
        }
    }
}
