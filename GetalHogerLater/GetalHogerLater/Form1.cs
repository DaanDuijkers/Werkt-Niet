using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetalHogerLater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random r = new Random();
            int getal1 = r.Next(1, 10);
            int getal2 = r.Next(1, 10);

            lblGetal1.Text = getal1.ToString();
            lblGetal2.Text = getal2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getal1 = Convert.ToInt32(lblGetal1.Text);
            int getal2 = Convert.ToInt32(lblGetal2.Text);
            int correct = getal1 * getal2;
            int uitkomst = Convert.ToInt32(txbUitkomst.Text);

            if(uitkomst == correct)
            {
                lblCorrect.Text = "CORRECT! Goed gedaan!";
            }
            else
            {
                lblCorrect.Text = "FOUT! Probeer opnieuw!";
            }
        }
    }
}
