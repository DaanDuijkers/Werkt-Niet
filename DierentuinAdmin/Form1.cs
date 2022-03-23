using DierentuinAdmin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DierentuinAdmin
{
    public partial class Form1 : Form
    {
        DatabaseRead reader = new DatabaseRead();
        Dierentuin dierentuin = new Dierentuin();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reader.ComboboxData("SELECT * FROM Dierentuinen");
            cmbRead.DataSource = reader.dataFill;

            gvRead.DataSource = null;
            gvRead.DataSource = dierentuin.ViewDierentuin();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRead.Text == "----SELECT----")
            {
                gvRead.DataSource = null;
                gvRead.DataSource = dierentuin.ViewDierentuin();
            }
            else
            {
                gvRead.DataSource = null;
                gvRead.DataSource = dierentuin.SelectDierentuin(cmbRead.Text);
            }
        }
    }
}
