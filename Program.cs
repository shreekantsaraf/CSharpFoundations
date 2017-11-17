﻿/*
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
            TypeConversion();
            //RepeatIt();
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
            press 5 for exercise5
            press 6 for exercise6
            press 7 for exercise7
            press A for NullCheck()
            press B for stringTokenizer
            press any other key for ending this session
            
            ");

            ConsoleKey myKey;

            myKey = Console.ReadKey().Key;
            if (myKey == ConsoleKey.D3) { exercise3(); RepeatIt(); }
            if (myKey == ConsoleKey.D4) { exercise4(); RepeatIt(); }
            if (myKey == ConsoleKey.D5) { exercise5(); RepeatIt(); }
            if (myKey == ConsoleKey.D6) { exercise6(); RepeatIt(); }
            if (myKey == ConsoleKey.D7) { exercise7(); RepeatIt(); }
            if (myKey == ConsoleKey.A) { NullCheck(); RepeatIt(); }
            if (myKey == ConsoleKey.B) { stringTokenizer(); RepeatIt(); }
            Console.WriteLine();
       }

        static void stringTokenizer()
        {

            string s = "this is a string that needs to be tokenized";
            Console.WriteLine(@"
            The original string is 
            " +s);
            char tokenizingChar = ' ';
            Console.WriteLine("tokenizing char is space");
            string[] tokens = s.Split(tokenizingChar);
            Console.WriteLine("we have " + tokens.Length + "  number of tokens in the string. and the tokens are - ");
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }
            Console.WriteLine(@"
            
            stringTokenizer Completed. press any key to continue
            ");
            Console.ReadKey();
            Console.WriteLine(@"
            .......................stringTokenizer ends.......................

            ");
        }
        class AnotherClass
        {
            public AnotherClass()
            {
                Console.WriteLine("AnotherClass() constructore");
            }
            public long MultipleTwoNumbers(int A, int B)
            {
                Console.WriteLine("entering AnotherClass::MultipleTwoNumbers");
                Console.WriteLine(@"
                public long AnotherClass::MultipleTwoNumbers(int A, int B) received two params 
                A = " + A +@"
                B = " + B);
                long ret = A * B;
                Console.WriteLine("returning A*B = " +ret);
                Console.WriteLine("leaving AnotherClass::MultipleTwoNumbers");
                return ret;
            }
        }
        static public int TypeConversion()
        {
            long minutes = 525600;
            int years = 1;

            years = Convert.ToInt32(minutes);

            return years;
        }
        static long MultipleTwoNumbers(int A, int B)
        {
            Console.WriteLine("entering static MultipleTwoNumbers");
            Console.WriteLine(@"
                static long MultipleTwoNumbers(int A, int B) received two params 
                A = " + A + @"
                B = " + B);
            long ret = A * B;
            Console.WriteLine("returning A*B = " + ret);
            Console.WriteLine("leaving static MultipleTwoNumbers");
            return ret;
        }

        static void exercise7()
        {
            /*
             C# Exercise 7
               ** */


            Console.WriteLine(".......................Exercise7 starts.......................");
            string note = @"
            C# Exercise 7: 
            Create a new branch in your CSharpFoundations repository called C# Exercise #7
            Remove all of the code in your Main method of the Program class
            create a static function MultipleTwoNumbers
            create a similar function MultipleTwoNumbers in a class.
            observe that static MultipleTwoNumbers doesn't need you to instantiate the any class.
            But class::MultipleTwoNumbers will need you to instantiate a class.
            Commit and merge your changes to your local repository and Github
            ";
            Console.WriteLine(note);
            Console.WriteLine("calling static MultipleTwoNumbers");
            MultipleTwoNumbers(2, 5);
            Console.WriteLine();
            Console.WriteLine("initiating AnotherClass");
            AnotherClass ac = new AnotherClass();
            Console.WriteLine("calling AnotherClass::MultipleTwoNumbers");
            ac.MultipleTwoNumbers(10, 7);
            Console.WriteLine(@"
            Exercise Completed. press any key to continue
            ");
            Console.ReadKey();
            Console.WriteLine(@"
            .......................Exercise7 ends.......................
            ");

        }

        static void exercise6()
        {
            /*
             C# Exercise 5 
               ** */


            Console.WriteLine(".......................Exercise6 starts.......................");
            string note = @"
            C# Exercise 6: 
            Create a new branch in your CSharpFoundations repository called C# 
            Exercise #6
            Remove all of the code in your Main method of the Program class
            Create a string variable called gameOfThronesPremier and assign it a string of April 17, 2011
            Using the Convert class, convert your gameOfThronesPremierDate variable to a DateTime 
            and assign it to a new DateTime variable called gameOfThronesPremierDate
            Write the value of gameOfThronesPremierDate to the console window 
                using the ToString method to convert the date to a string
            Commit and merge your changes to your local repository and Github
            ";
            Console.WriteLine(note);
            string gameOfThronesPremier = "April 17, 2011";
            Console.WriteLine("gameOfThronesPremier = " + gameOfThronesPremier.ToString());
            DateTime gameOfThronesPremierDate = Convert.ToDateTime(gameOfThronesPremier);
            Console.WriteLine("gameOfThronesPremierDate = " + gameOfThronesPremierDate.ToString());

            Console.WriteLine(@"
            
            Exercise Completed. press any key to continue
            ");
            Console.ReadKey();
            Console.WriteLine(@"
            .......................Exercise6 ends.......................

            ");

        }

        static void exercise5()
        {
            /*
             C# Exercise 5 
               ** */


            Console.WriteLine(".......................Exercise5 starts.......................");
            string note = @"
            Exercise5  -
            Create a new branch in your CSharpFoundations repository called C# 
            Exercise #5
            Remove all of the code in your Main method of the Program class
            Create a string array with the following values:Sansa Bran Eddard Arya 
            Use a foreach loop to print each name to the console window
            Commit and merge your changes to your local repository and Github
            ";
            Console.WriteLine(note);
            string s = @"
            I am building a string array with the primitive way ---
            string[] sa = new string[4]; //step1 - declare it in first step 
            sa[0] = ""Sansa""; //step2 - then instantiate it in the snext steps...
            ";
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            Console.WriteLine(sb.ToString());
            string[] sa = new string[4];
            sa[0] = "Sansa";
            sa[1] = "Bran";
            sa[2] = "Eddard";
            sa[3] = "Arya";
            foreach (string item in sa)
            {
                Console.Write(@"
                " + item);
            }
            Console.WriteLine();
            sb.Clear();
            s = @"
            I am building a string array with another primitive way ---- 
            string[] sa = new string[] {""Sansa"", ""Bran""};// instantiate the array while declaring it 
            ";
            sb.Append(s);
            Console.WriteLine(sb.ToString());
            string[] sa2 = new string[] {
            "Sansa",
            "Bran",
            "Eddard",
            "Arya"};
            foreach (string item in sa)
            {
                Console.Write(@"
                " + item);
            }
            Console.WriteLine();

            Console.WriteLine(@"
            
            Exercise Completed. press any key to continue
            ");
            Console.ReadKey();
            Console.WriteLine(@"
            .......................Exercise5 ends.......................

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
        static void NullCheck()
        {
            Console.WriteLine(@"


            .......................NullCheck starts.......................
            ");
            Console.WriteLine(@"
            This is just a plain function that checks and validates the HasValue property of a nullable variable");
            int? empty = null;
            bool bRet = empty.HasValue ? true : false;

            Console.WriteLine("value of bRet is  " + bRet + "  press any key to continue");
            Console.ReadKey();
            Console.WriteLine(@"

            .......................NullCheck ends.......................
            ");

        }

    }
}
