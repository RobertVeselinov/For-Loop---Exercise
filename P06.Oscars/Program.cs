using System;

namespace P06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double scoreFromAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string evaluative = string.Empty;
            double evaliativeScore = 0;
            double evaliativeScore1 = scoreFromAcademy;

            for (int i = 1; i <= n; i++)
            {
                evaluative = Console.ReadLine();
                evaliativeScore = double.Parse(Console.ReadLine());

                evaliativeScore1 += evaluative.Length * evaliativeScore / 2;

                if (evaliativeScore1 > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {evaliativeScore1:f1}!");
                    break;
                }
            }
            if (evaliativeScore1 < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - evaliativeScore1:f1} more!");
            }
        }
    }
}
