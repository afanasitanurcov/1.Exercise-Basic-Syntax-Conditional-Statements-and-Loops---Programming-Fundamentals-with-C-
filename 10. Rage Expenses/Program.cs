using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lostGames = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double crushedHeadsets = Math.Floor(lostGames / 2);

                double crushedMouses = Math.Floor(lostGames / 3);

                double crushedKeyboards = Math.Floor(lostGames / 6);

                double crushedDisplays = Math.Floor(lostGames / 12);

            double finalPrice = (crushedHeadsets * headsetPrice +  crushedMouses * mousePrice +  crushedKeyboards * keyboardPrice + crushedDisplays * displayPrice);


            Console.WriteLine($"Rage expenses: {finalPrice:F2} lv.");
        }
    }
}
