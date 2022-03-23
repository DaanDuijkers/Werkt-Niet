using System;
using System.Windows.Forms;

namespace hogerLager
{
    public partial class hogerLager : Form
    {
        // onderGrens houd het laagst geraden getal bij
        int onderGrens;

        // bovenGrens houd het hoogst geraden getal bij
        int bovenGrens;

        // keuzeGetal is het getal tussen de boven- en onderGrens
        int keuzeGetal;

        // pogingen houd de porgingen bij
        int pogingen = 0;

        public hogerLager()
        {
            InitializeComponent();
        }

        private void hogerLager_Load(object sender, EventArgs e)
        {
            // In het begin is de onderGrens altijd 0
            onderGrens = 0;

            // In het begin is de bovenGrens altijd 101
            bovenGrens = 101;

            // som() roept de "public void som()" aan
            som();
        }

        // "public void som()" is de fuctie die word aangeroepen om de 
        public void som()
        {
            if (pogingen <= 10)
            {
                // Hier word het keuzeGetal tussen de onder- en bovenGrens gepaald
                keuzeGetal = (onderGrens + bovenGrens) / 2;

                // hier word keuzeGetal uitgetyped
                lblUitkomst.Text = onderGrens.ToString() + " + " + bovenGrens.ToString() + " : 2 = " + keuzeGetal.ToString();

                // hierna neemt de hoeveelheid pogingen toe met 1
                pogingen++;
            }
            else
            {
                // Als het programma niet binnen 10 pogingen het juiste getal raad verliest het
                lblUitkomst.Text = "Ik heb verloren...";
            }
        }

        // klik als het juiste getal hoger is dan het geraden getal
        private void btnHoger_Click(object sender, EventArgs e)
        {
            onderGrens = keuzeGetal;
            som();
        }

        // klik als het juiste getal lager is dan het geraden getal
        private void btnLager_Click(object sender, EventArgs e)
        {
            bovenGrens = keuzeGetal;
            som();
        }

        // klik als het geraden getal het juiste getal is
        private void btnGoed_Click(object sender, EventArgs e)
        {
            lblUitkomst.Text = "Ik Win!";
            btnHoger.Enabled = false;
            btnLager.Enabled = false;
        }
    }
}
