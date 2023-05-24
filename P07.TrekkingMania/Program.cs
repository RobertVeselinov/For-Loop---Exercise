using System;

namespace P07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int quantityPeople;

            int musalla = 0;
            int montBlanc = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;

            int sumAll = 0;
            for (int i = 1; i <= n; i++)
            {
                quantityPeople = int.Parse(Console.ReadLine());
                sumAll += quantityPeople;
                if (quantityPeople <= 5)
                {
                    musalla += quantityPeople;
                }
                else if (quantityPeople >= 6 && quantityPeople <= 12)
                {
                    montBlanc += quantityPeople;
                }
                else if (quantityPeople >= 13 && quantityPeople <= 25)
                {
                    kilimanjaro += quantityPeople;
                }
                else if (quantityPeople >= 26 && quantityPeople <= 40)
                {
                    k2 += quantityPeople;
                }
                else if (quantityPeople >= 41)
                {
                    everest += quantityPeople;
                }
            }
            Console.WriteLine($"{(double)musalla / sumAll * 100:f2}%");
            Console.WriteLine($"{(double)montBlanc / sumAll * 100:f2}%");
            Console.WriteLine($"{(double)kilimanjaro / sumAll * 100:f2}%");
            Console.WriteLine($"{(double)k2 / sumAll * 100:f2}%");
            Console.WriteLine($"{(double)everest / sumAll * 100:f2}%");
        }
    }
}
