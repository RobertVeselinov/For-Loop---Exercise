using System;

namespace P08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int score = int.Parse(Console.ReadLine());

            string wOrForSF = string.Empty;
            int finalScore = score;
            int quantityТournaments = 0;
            int quantityWins = 0;


            for (int i = 1; i <= n; i++)
            {
                wOrForSF= Console.ReadLine();
                quantityТournaments += 1;

                if (wOrForSF == "W")
                {
                    finalScore += 2000;
                    quantityWins += 1;
                }
                else if (wOrForSF == "F")
                {
                    finalScore += 1200;
                }
                else if (wOrForSF == "SF")
                {
                    finalScore += 720;
                }
            }
            double averageScore = (finalScore - score) / quantityТournaments;
            double procent = (double)quantityWins / quantityТournaments * 100;

            Console.WriteLine($"Final points: {finalScore}");
            Console.WriteLine($"Average points: {Math.Floor(averageScore)}");
            Console.WriteLine($"{procent:f2}%");
        }
    }
}
