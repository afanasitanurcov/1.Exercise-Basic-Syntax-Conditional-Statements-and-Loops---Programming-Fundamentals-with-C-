using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double peopleDiscount = 0;
            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = countOfPeople * 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = countOfPeople * 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        price = countOfPeople * 10.46;
                    }
                    if (countOfPeople >= 30)
                    {
                        price = price * 0.85;
                    }
                    Console.WriteLine($"Total price: {price:F2}");
                    break;

                case "Business":
                    if (day == "Friday")
                    {
                        price = countOfPeople * 10.90;
                        peopleDiscount = 10 * 10.90;

                    }
                    else if (day == "Saturday")
                    {
                        price = countOfPeople * 15.60;
                        peopleDiscount = 10 * 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        price = countOfPeople * 16;
                        peopleDiscount = 10 * 16;
                    }
                    if (countOfPeople >= 100)
                    {
                        price = price - peopleDiscount;

                    }
                        Console.WriteLine($"Total price: {price:F2}");
                    break;

                case "Regular":
                    if (day == "Friday")
                    {
                        price = countOfPeople * 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = countOfPeople * 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = countOfPeople * 22.50;
                    }

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price = price * 0.95;
                    }

                    Console.WriteLine($"Total price: {price:F2}");
                    break;

                    
            }

        }
    }
}
