using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            string WorForSF = string.Empty;
            int pointsFromTournaments = 0;
            int winTournaments = 0;

            for (int i = 1; i <= tournaments; i ++)
            {
                WorForSF = Console.ReadLine();

                if (WorForSF == "W")
                {
                    startPoints += 2000;
                    pointsFromTournaments += 2000;
                    winTournaments++;
                }
                else if (WorForSF == "F")
                {
                    startPoints += 1200;
                    pointsFromTournaments += 1200;
                }
                else if (WorForSF == "SF")
                {
                    startPoints += 720;
                    pointsFromTournaments += 720;
                }
            }
            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {Math.Floor((double)pointsFromTournaments / tournaments)}");
            Console.WriteLine($"{(double)winTournaments / tournaments * 100:f2}%");

        }
    }
}



