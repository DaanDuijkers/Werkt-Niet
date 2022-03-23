using Dierentuin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dierentuin
{
    public partial class Form1 : Form
    {
        Dierentuinen dierentuin = new Dierentuinen();
        Dier dier = new Dier();
        Werker werker = new Werker();
        Verzorger verzorger = new Verzorger();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dierentuinTableAdapter.Fill(dierentuinDataSet.Dierentuin);
            dierTableAdapter.Fill(dierentuinDataSet.Dier);

            loadGridviews();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            switch (tabDierentuin.SelectedIndex)
            {
                case 0:
                    dierentuin.Naam = txbDierentuinNaam.Text;
                    dierentuin.Adres = txbDierentuinAdres.Text;
                    dierentuin.Budget = Convert.ToDouble(txbDierentuinBudget.Text);

                    dierentuin.InsertDierentuinen();

                    MessageBox.Show("Dierentuin: " + dierentuin.Naam + " is toegevoegd!");
                    break;
                case 1:
                    dier.Soort = txbDierSoort.Text;
                    dier.Naam = txbDierNaam.Text;
                    dier.Locatie = txbDierLocatie.Text;
                    dier.Eten = txbDierEten.Text;
                    dier.Geslacht = cmbDierGeslacht.Text;
                    dier.DierentuinID = Convert.ToInt32(cmbDierDierentuin.SelectedValue);
                    dier.Prijs = Convert.ToDouble(txbDierPrijs.Text);

                    dier.Insert();

                    MessageBox.Show("Dier is toegevoegd");
                    break;
                case 2:
                    werker.Voornaam = txbWerkerVoornaam.Text;
                    werker.Tussenvoegsel = txbWerkerTussenvoegsel.Text;
                    werker.Achternaam = txbWerkerAchternaam.Text;
                    werker.Werkzaamheden = txbWerkerWerkzaamheden.Text;
                    werker.BeginTijd = Convert.ToDateTime(dtpWerkerBeginTijd.Text);
                    werker.EindTijd = Convert.ToDateTime(dtpWerkerEindTijd.Text);
                    werker.DierentuinID = Convert.ToInt32(cmbWerkerDierentuin.SelectedValue);
                    //werker.Salaris = Convert.ToDouble(txbWerkerSalaris.Text);

                    werker.Insert();

                    MessageBox.Show("Werker " + werker.Voornaam + " " + werker.Tussenvoegsel + " " + werker.Achternaam + " is toegevoegd!");
                    break;
                case 3:
                    verzorger.Dier = txbVerzorgerDier.Text;
                    verzorger.Voornaam = txbVerzorgerVoornaam.Text;
                    verzorger.Tussenvoegsel = txbVerzorgerTussenvoegsel.Text;
                    verzorger.Achternaam = txbVerzorgerAchternaam.Text;
                    verzorger.Werkzaamheden = "Verzorger";
                    verzorger.BeginTijd = Convert.ToDateTime(dtpVerzorgerBeginTijd.Text);
                    verzorger.EindTijd = Convert.ToDateTime(dtpVerzorgerEindTijd.Text);
                    verzorger.DierentuinID = Convert.ToInt32(cmbVerzorgerDierentuin.SelectedValue);

                    verzorger.Insert();

                    MessageBox.Show("Verzorger is toegevoegd!");
                    break;
            }

            loadGridviews();
            empty();
        }

        private void tabDierentuin_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGridviews();
            empty();
        }

        private void loadGridviews()
        {
            gvDierentuin.DataSource = null;
            gvDier.DataSource = null;
            gvWerker.DataSource = null;
            gvVerzorger.DataSource = null;

            switch (tabDierentuin.SelectedIndex)
            {
                case 0:
                    gvDierentuin.DataSource = dierentuin.View();
                    break;
                case 1:
                    gvDier.DataSource = dier.View();
                    break;
                case 2:
                    gvWerker.DataSource = werker.View();
                    break;
                case 3:
                    gvVerzorger.DataSource = verzorger.View();
                    break;
            }
        }

        private void empty()
        {
            switch (tabDierentuin.SelectedIndex)
            {
                case 0:
                    txbDierentuinAdres.Text = string.Empty;
                    txbDierentuinNaam.Text = string.Empty;
                    txbDierentuinBudget.Text = string.Empty;
                    break;
                case 1:
                    txbDierSoort.Text = string.Empty;
                    txbDierNaam.Text = string.Empty;
                    txbDierLocatie.Text = string.Empty;
                    txbDierEten.Text = string.Empty;
                    cmbDierGeslacht.Text = "Man";
                    cmbDierDierentuin.SelectedIndex = 0;
                    cmbFilterDierentuin.SelectedIndex = 0;
                    break;
                case 2:
                    txbWerkerVoornaam.Text = string.Empty;
                    txbWerkerTussenvoegsel.Text = string.Empty;
                    txbWerkerAchternaam.Text = string.Empty;
                    txbWerkerWerkzaamheden.Text = string.Empty;
                    cmbWerkerDierentuin.SelectedIndex = 0;
                    break;
                case 3:
                    txbVerzorgerVoornaam.Text = string.Empty;
                    txbVerzorgerTussenvoegsel.Text = string.Empty;
                    txbVerzorgerAchternaam.Text = string.Empty;
                    txbVerzorgerWerkzaamheden.Text = string.Empty;
                    cmbVerzorgerDierentuin.SelectedIndex = 0;
                    txbVerzorgerDier.Text = string.Empty;
                    break;
            }
        }

        private void btnFilterDierentuin_Click(object sender, EventArgs e)
        {
            gvDierentuin.DataSource = null;
            gvDierentuin.DataSource = dierentuin.Filter(Convert.ToInt32(cmbFilterDierentuin.SelectedValue));
        }

        private void btnVerzorgerSelectDier_Click(object sender, EventArgs e)
        {
            gvVerzorger.DataSource = null;
            gvVerzorger.DataSource = verzorger.Filter(Convert.ToInt32(txbVerzorgerID.Text));
        }
    }
}
