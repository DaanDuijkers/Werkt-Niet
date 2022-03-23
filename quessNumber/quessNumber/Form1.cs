using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quessNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number;
        int pogingen = 10;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if (pogingen >= 0)
            {
                int guess = Convert.ToInt32(txbInput.Text);

                if (guess > number)
                {
                    pogingen--;
                    MessageBox.Show("Lager! U heeft nog " + pogingen + " pogingen!");
                }
                else if (guess < number)
                {
                    pogingen--;
                    MessageBox.Show("Hoger! U heeft nog " + pogingen + " pogingen!");
                }
                else if (guess == number)
                {
                    MessageBox.Show("Gefeliciteerd! " + number + " is het juiste nummer!");
                    pogingen = 10;
                    number = random.Next(0, 101);
                    MessageBox.Show("Er is een nieuw nummer gegenereerd");
                }
            }

            if (pogingen == 0)
            {
                MessageBox.Show("U heeft geen pogingen meer! Er word een nieuw nummer gegenereerd");
                number = random.Next(0, 101);
                pogingen = 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            number = random.Next(0, 101);
            MessageBox.Show("U heeft 10 pogingen om het een nummer van 1 tot 100 te raden!");
        }
    }
}
