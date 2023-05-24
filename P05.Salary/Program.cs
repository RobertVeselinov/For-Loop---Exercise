using System;

namespace P05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fee = 0;
            for (int i = 1; i <= n; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    fee += 150;
                }
                else if (site == "Instagram")
                {
                    fee += 100;
                }
                else if (site == "Reddit")
                {
                    fee += 50;
                }

                if (salary - fee <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }
            }
            if (salary - fee > 0)
            {
                Console.WriteLine($"{Math.Abs(salary - fee)}");
            }

        }
    }
}
