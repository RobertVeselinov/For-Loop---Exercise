using System;

namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            double sumPriceToy = 0;
            int sumMoney = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sumMoney += i / 2 * 10 - 1;
                }
                else
                {
                    sumPriceToy++;
                }
            }
            double finalPriceToy = sumPriceToy * priceToy;
            double sumAll = sumMoney + finalPriceToy;

            if (sumAll >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {Math.Abs(sumAll - priceWashingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(priceWashingMachine - sumAll):f2}");
            }
        }
    }
}
