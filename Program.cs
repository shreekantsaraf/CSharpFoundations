/*
 * Exercise File
 */
 
using System;
using System.Text;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatIt();
        }

        static void RepeatIt()
        {
            Console.Clear();
            Console.WriteLine(@"
            .......................Exercises start.......................
            press 1 for exercise1 (under construction)
            press 2 for exercise2 (under construction)
            press 3 for exercise3
            press 4 for exercise4
            press any other key for ending this session
            
            ");

            ConsoleKey myKey;

            myKey = Console.ReadKey().Key;
            if (myKey == ConsoleKey.D3) { exercise3(); RepeatIt(); }
            if (myKey == ConsoleKey.D4) { exercise4(); RepeatIt(); }
            Console.WriteLine();

        }

        static void exercise3()
        {// I am writing this class in the VS 2017 community edition. The VS2017 can checkin the changes to GIT directly. Wow!
         /*
          C# Exercise 3 StringBuilder+FizzBuzz: 
            Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number 
            and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
            ** */


            Console.WriteLine(".......................Exercise3 starts.......................");
            string note = @"

            C# Exercise 3 
            This checkin is really a combination of Exercise3 that expects us to use StringBuilder and the FizzBuzz program.
            FizzBuzz is a traditional program to test programmer's coding conceptual clarity...
            FizzBuzz - Write a program that prints the numbers from 1 to 100. 
            But for multiples of three print 'Fizz' instead of the number. (I have modified it to use number +'Fizz')
            and for the multiples of five print 'Buzz'. (I have modified it to use number +'Buzz')
            For numbers which are multiples of both three and five print 'FizzBuzz'. (I have modified it to use number +'FizzBuzz')
            ";
            Console.WriteLine(note);
            string s = "hello, Please enter number between 5 and 20 - ";
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            Console.WriteLine(s.ToString());
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                Console.Write(number + " ");
                if (number % 3 == 0) Console.Write("Fizz");
                if (number % 5 == 0) Console.Write("Buzz");
                Console.WriteLine();
                number = number - 1;
            }
            Console.WriteLine(@"
            
            Exercise Completed. press any key to continue
            ");
            Console.ReadKey();
            Console.WriteLine(@"
            .......................Exercise3 ends.......................

            ");
            
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

            bool hasBonus = false; // non nullable bool

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
