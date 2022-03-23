using System;
using System.Numerics;

namespace verdubbelen
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger hp = 352;
            BigInteger mp = 378;
            BigInteger attack = 322;
            BigInteger defense = 316;

            bool check = false;
            for (int teller = 1; teller < 100; teller++)
            {
                if (hp > 9999 && mp > 9999 && attack > 9999 && defense > 9999 && check == false)
                {
                    check = true;
                    Console.WriteLine("Hero, LV99");
                    Console.WriteLine("HP:          9999");
                    Console.WriteLine("MP:          9999");
                    Console.WriteLine("Attack:      9999");
                    Console.WriteLine("Defense:     9999");
                    Console.WriteLine("");
                }

                Console.WriteLine("Miko Hero, LV" + teller);
                Console.WriteLine("HP:          " + hp);
                Console.WriteLine("MP:          " + mp);
                Console.WriteLine("Attack:      " + attack);
                Console.WriteLine("Defense:     " + defense);
                Console.WriteLine("");

                hp = hp * 2;
                mp = mp * 2;
                attack = attack * 2;
                defense = defense * 2;
            }
            
            Console.ReadKey();
        }
    }
}
