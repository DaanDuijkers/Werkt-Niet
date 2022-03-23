using oopDatabase.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopDatabase
{
    public partial class Form1 : Form
    {
        Connection Test = new Connection();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
                Test.Insert("INSERT INTO dierentuinen(Naam, Adres) VALUES('Test','Test')");
                MessageBox.Show("Test gelukt!");
        }
    }
}
