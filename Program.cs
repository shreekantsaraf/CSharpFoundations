/*Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number 
and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
 */
using System;
using System.Text;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
             exercise4();
        }
        static void exercise4()
        {// I am writing this class in the VS 2017 community edition. The VS2017 can checkin the changes to GIT directly. Wow!
            /*
             C# Exercise 4: 
             Create a new branch in your CSharpFoundations repository called C# Exercise #4
             Remove all of the code in your Main method of the Program class 
             Create a nullable int variable called bonus and set the initial value to null
             Create another variable called hasBonus and set it’s initial value to false
             Write an if statement that sets hasBonus to true if the bonus variable has a value.
             Commit and merge your changes to your local repository and Github
             * * */


            Console.WriteLine(".......................Exercise4 starts.......................");
            string note = @"

             C# Exercise 4: 
             Create a new branch in your CSharpFoundations repository called C# Exercise #4 
             Remove all of the code in your Main method of the Program class
             Create a nullable int variable called bonus and set the initial value to null
             Create another variable called hasBonus and set it’s initial value to false
             Write an if statement that sets hasBonus to true if the bonus variable has a value.
             Commit and merge your changes to your local repository and Github
            ";
            Console.WriteLine(note);
            Console.WriteLine(@"
            Do you want bonus to be assigned 100 dollars? Press y for yes press any other key for no....
            ");
            //ConsoleKey key = Console.ReadKey().KeyChar;
            int? bonus = null; //Nullable int
            ConsoleKey myKey;
            myKey = Console.ReadKey().Key;
            if (myKey == ConsoleKey.Y)
            {
                bonus = 100;
            }
            Console.WriteLine(@"
            you pressed key = " + myKey);
            bool hasBonus  = false; // non nullable bool
            if (bonus.HasValue)
            {
                hasBonus = true;
                Console.WriteLine(@"
                bonus has a value  = " + bonus);
                Console.WriteLine(@"
                setting hasBonus " + hasBonus);
            }
            else
            {
                Console.WriteLine(@"
                bonus has no value and thus hasBonus = " + hasBonus);
            }
            Console.WriteLine(@"
            
            Exercise Completed. press any key to continue
            ");
            Console.ReadKey();
            Console.WriteLine(@"
            .......................Exercise4 ends.......................

            ");
        }
    }
}
