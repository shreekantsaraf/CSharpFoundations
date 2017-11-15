/*Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number 
and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
 */
using System;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, Please enter number between 5 and 20 - ");
            int number = int.Parse(Console.ReadLine());
            while (number > 0) 
            {
                Console.Write(number + " ");
                if (number % 3 == 0) Console.Write("Fizz");
                if (number % 5 == 0) Console.Write("Buzz");
                Console.WriteLine();
                number= number-1;
            }
            Console.WriteLine("done. press any key");
            Console.ReadKey();
        }
    }
}
