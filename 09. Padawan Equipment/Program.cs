using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double amountOfMoney = double.Parse(Console.ReadLine());
            double studentsCount = double.Parse(Console.ReadLine());
            double priceOfLightSiber = double.Parse(Console.ReadLine());
            double priceOfRob = double.Parse(Console.ReadLine());
                double priceOfBelt = double.Parse(Console.ReadLine());

            double necessaryLightSibers = Math.Ceiling(studentsCount * 1.1);

            double finalSibersPrice = necessaryLightSibers * priceOfLightSiber;

            double finalRobesPrice = studentsCount * priceOfRob;

            double beltDiscount = Math.Floor(studentsCount / 6);

            double finalBeltsPrice = (studentsCount - beltDiscount) * priceOfBelt;

            double finalPrice = finalBeltsPrice + finalRobesPrice + finalSibersPrice;

            if (amountOfMoney >= finalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:F2}lv.");

            }
            else
            {
                Console.WriteLine($"John will need {(finalPrice - amountOfMoney):F2}lv more.");
            }

           



        }
    }
}
