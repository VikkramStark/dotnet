using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of " + number + " is: " + factorial);
        }
    }
}
