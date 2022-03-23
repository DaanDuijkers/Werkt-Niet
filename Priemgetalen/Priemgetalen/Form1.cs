using System.Windows.Forms;

namespace Priemgetalen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Deze bool houd bij of het huidige getal een priemgetal is
            bool isPrimeNumber = true;

            // Deze loop gaat door alle getallen tussen 1 t/m 1000 heen
            for (int i = 1; i < 1000; i++)
            {
                // Deze loop gaat door alle getallen kleiner dan het huidige getal heen
                for (int k = 2; k < i; k++)
                {
                    // Als het getal gedeeld door een getal behalve een volledig getal terug geeft is het geen priemgetal
                    if (i % k == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }

                // Als het getal een priemgetal is word het in de ListBox uitgedrukt
                if (isPrimeNumber)
                {
                    lbPrimeNumbers.Items.Add(i);
                }

                // Als de bool isPrimeNumber op false werd gezet word hij hier weer op true gezet
                isPrimeNumber = true;
            }
        }
    }
}
