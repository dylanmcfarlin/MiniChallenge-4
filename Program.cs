using System;

// Dylan McFarlin
// Date Revised: 9-3-20
// MiniChallenge#4
// Program that asks the user to enter two numbers and prints out two statements:
// first statement: should say if the first number is greater than, less than, or equal to the second number.
// second statement: should tell me if the second number is greater than, less than, or equal to the first number.
// Code Reviewed by: Tyler Rose
// Comments: Program runs perfect!

namespace MiniChallenge_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter number 1:");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            int num2 = Convert.ToInt16(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater than " + num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num1 + " is less than " + num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine(num1 + " is equal to " + num2);
            }
            if (num2 > num1)
            {
                Console.WriteLine(num2 + " is greater than " + num1);
            }
            else if (num2 < num1)
            {
                Console.WriteLine(num2 + " is less than " + num1);
            }
            else if (num2 == num1)
            {
                Console.WriteLine(num2 + " is equal to " + num1);
            }
        }
    }
}
