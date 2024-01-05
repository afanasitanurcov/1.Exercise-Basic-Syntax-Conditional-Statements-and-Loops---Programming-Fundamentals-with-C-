using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0, sum = 0;
           
            number = Convert.ToInt32(Console.ReadLine());
            int quot = number;
            int remainder;
            while (quot != 0)
            {
                remainder = quot % 10;
                int fact = CalculateFactorial(remainder);
                quot = quot / 10;
                sum = sum + fact;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        //Calulate Factorial of a number 
        public static int CalculateFactorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
