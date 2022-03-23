using System;
using System.Collections.Generic;

namespace PrimeNumbersList
{
    class Program
    {
        static void Main(string[] args)
        {
            // In deze List worden de priemgetallen opgeslagen
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);

            // Hier gaat het programma door alle getallen van 2 tot 100 heen
            for (int getal = 2; getal <= 100; getal++)
            {
                // Houd bij of het een priemtal is; elke keer dat een nieuw getal word gecheckt word deze op true gezet
                bool isPrime = true;

                // Deze loop gaat een keer door de getallen heen voor ieder getal in de List
                for (int deelGetal = 1; deelGetal < primeNumbers.Count; deelGetal++)
                {
                    // Als het getal gedeeld door een getal in de List een heel getal terug geeft is het geen priemgetal
                    if (getal % primeNumbers[deelGetal] == 0)
                    {
                        isPrime = false;
                    }
                }

                // Als het huidige getal een priemgetal is word deze in de lijst geplaatst
                if (isPrime == true)
                {
                    primeNumbers.Add(getal);
                }
            }

            // Schrijft alle getallen in de List uit
            foreach (int prime in primeNumbers)
            {
                Console.WriteLine(prime);
            }

            Console.ReadKey();
        }
    }
}
