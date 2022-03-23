using System;

namespace volgorde
{
    class Program
    {
        // Deze methode hieronder word gebuikt voor de uitvoer
        public static double invoer(string boodschap)
        {
            double x;

            Console.Write(boodschap);
            x = double.Parse(Console.ReadLine());
            return x;
        }

        static void Main()
        {
            // hieronder word de array aangemaakt, maar en staan nog geen cijfers in
            double[] getal = new double [10];

            //hieronder worden de getallen ingevoerd en in de array gestopt
            for (int teller = 0; teller < 10; teller++)
            {
                getal[teller] = invoer("voer een cijfer in: ");
                //getal [teller] = double.Parse(Console.ReadLine());
            }
            
            // hieronder staat een variabel die gebruikt zal worden op de cijfers op de juiste volgorde te zetten
            double temp;

            // een loop die gebruik word voor ieder nummer om te checken of ze op de juiste volgorde staat
            int voor = 0;
            while (voor < getal.Length)
            {
                // ieder nummer gaat de onderstaande loop een keer door alle nummers heen om zeken te zijn dat deze in de
                    // juiste volgorde staan
                int achter = 0;
                while (achter < getal.Length)
                {
                    // Als het achterste getal lager is dan het voorste getal staan deze niet in de juiste volgorder en 
                        // zullen deze worden omgedraaid
                    if (getal [voor] < getal [achter])
                    {
                        temp = getal [voor];
                        getal [voor] = getal [achter];
                        getal [achter] = temp;
                    }

                    achter++;
                }

                voor++;
            }

            // nadat we zeker zijn dat alle cijfers op de juiste volgorde staan worden deze hier uitgeprint
            for (int teller = 0; teller < getal.Length; teller++)
            {
                Console.Write("\n" + getal [teller]);
            }
            
            Console.ReadKey();
        }
    }
}
