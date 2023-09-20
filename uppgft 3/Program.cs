using System;

namespace Abdullahi
{
    class program
    {
        static void Main(string[] args)
        {

            int startavgift = 300;

            int kostnadPerKilometer = 1;

            int kostnadPerExtraDag = 500;

            
            
            Console.WriteLine("hur många dagar vill du hyra bilen?");
            int antalDagar = int.Parse(Console.ReadLine());

            Console.WriteLine("hur många kilometer ska du köra?");
            double antalKilometer = double.Parse(Console.Realine());

            int totalhyra = startavgift + (antalDagar - 1) * kostnadPerExtraDag + (int) (antalKilometer * kostnadPerKilometer);

            Console.WriteLine($"den totala hyran blir: {totalhyra} kr");
        }
    }
}
