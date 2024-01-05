using System;
using System.Net.Http.Headers;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coinSum = 0;
         double coinValue = 0;
            double interSum = 0;
            double moneyLeft = 0;
            string finalProductName;
           while (true)
            {
                string coin = Console.ReadLine();
                if (coin == "Start")
                {
                    break;
                }
                coinValue = double.Parse(coin);

                if (coinValue != 0.1 && coinValue != 0.2 && coinValue != 0.5 && coinValue != 1 && coinValue != 2)
                {
                    Console.WriteLine($"Cannot accept {coinValue}");
                    continue;
                }
                coinSum += coinValue; 
            }
           
            while (true)
            {
                interSum = coinSum;
                string productName = Console.ReadLine();

                if ( productName != "Nuts" && productName != "Water" && productName != "Crisps" && productName != "Soda" && productName != "Coke" && productName != "End")
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                switch (productName)
                {
                    case "Nuts":
                        coinSum = coinSum - 2;
                        
                        break;
                    case "Water":
                        coinSum = coinSum - 0.7;
                        break;
                    case "Crisps":
                        coinSum = coinSum - 1.5;
                        break;
                    case "Soda":
                        coinSum = coinSum - 0.8;
                        break;
                    case "Coke":
                        coinSum = coinSum - 1;
                        break;
                    case "End":
                        Console.WriteLine($"Change: {coinSum:F2}");
                        return;

                }
                finalProductName = productName.ToLower();
                if (coinSum < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    coinSum = interSum;
                }
                else
                {
                    Console.WriteLine($"Purchased {finalProductName}");
                }




            }
        }
    }
}
