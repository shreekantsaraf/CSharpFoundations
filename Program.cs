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
            //TypeConversion();
            RepeatIt();
            //int.TryParse()
        }

        static void RepeatIt()
        {
            Console.Clear();
            Console.WriteLine(@"
            .......................Exercises start.......................
            press 1 for exercise1 (under construction)
            press 2 for exercise2 (under construction)
            press 3 for exercise3 - StringBuilder and the FizzBuzz program
            press 4 for exercise4 - nullable value-type varibale declarable (e.g. int? and HasValue)
            press 5 for exercise5 - building a string array with the primitive way (e.g. string[] s = {""svs"");)
            press 6 for exercise6 - use Convert.ToDateTime
            press 7 for exercise7 - static methods and non-static methods
            press 8 for exercise8 - usge of int.TryParse
            press 9 for exercise9 - StarkJumper (create a new string array and exclude a specific string such as Stark
            press Y for NullCheck()
            press Z for stringTokenizer
            press any other key for ending this session
            
            ");

            ConsoleKey myKey;

            myKey = Console.ReadKey().Key;
            if (myKey == ConsoleKey.D3) { exercise3(); RepeatIt(); }
            if (myKey == ConsoleKey.D4) { exercise4(); RepeatIt(); }
            if (myKey == ConsoleKey.D5) { exercise5(); RepeatIt(); }
            if (myKey == ConsoleKey.D6) { exercise6(); RepeatIt(); }
            if (myKey == ConsoleKey.D7) { exercise7(); RepeatIt(); }
            if (myKey == ConsoleKey.D8) { exercise8(); RepeatIt(); }
            if (myKey == ConsoleKey.D9) { exercise9(); RepeatIt(); }
            if (myKey == ConsoleKey.Y) { NullCheck(); RepeatIt(); }
            if (myKey == ConsoleKey.Z) { stringTokenizer(); RepeatIt(); }
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
        static void exercise12()
        {
            Console.Clear();
            Console.WriteLine(".......................Exercise12 start.......................");
            Console.WriteLine(@"
            ");


            Console.WriteLine(".......................Exercise12 End.......................");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
        static void exercise11()
        {
            Console.Clear();
            Console.WriteLine(".......................Exercise11 start.......................");
            Console.WriteLine(@"
            ");


            Console.WriteLine(".......................Exercise11 End.......................");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
        static void exercise10()
        {
            Console.Clear();
            Console.WriteLine(".......................Exercise10 start.......................");
            Console.WriteLine(@"
            ");


            Console.WriteLine(".......................Exercise10 End.......................");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
        class StarkJumper
        {
            public string[] stringManipulator(string [] inArray, string strToIgnore = "Stark")
            {
                string [] retArray  = new string[inArray.Length];
                int j=0;
                for (int i=0; i < inArray.Length; i++)
                {

                    string str = inArray[i];
                    if((String.Compare(str,strToIgnore,  StringComparison.OrdinalIgnoreCase) != 0))
                    {
                        retArray[j] = str;
                        j++;
                    }
                }  
                return retArray;
            }
        }
        static void exercise9()
        {
            Console.Clear();
            Console.WriteLine(".......................Exercise9 start.......................");
            Console.WriteLine(@"C# Exercise 9: Create a new branch in your CSharpFoundations repository called C# Exercise #9
            Create a new class called StarkJumper
            Create a method on the StarkJumper class that does the following:
            Takes an array of strings as a parameter
            Returns an array of strings
            Loops through the parameter array using a for loop
            Add each character from the parameter array to a new array unless they are a Stark
            Return the new array of strings that does not have the Starks
            In your Program.Main method, remove any previous code and create a string array of Game Of Thrones character names.
            Create an instance of StarkJumper and pass the array to the method that filters out the Starks
            Perform a console.writeline for each of the character names returned from the method
            Commit and merge your changes to your local repository and Github
            ");
            StarkJumper sj = new StarkJumper();
            //string [] arraySent = {"a", "b", "u"};
            Console.WriteLine(@"
            Type in an array of strings. example is - 
            Sansa Bran Stark Eddard Stark Arya 
            if you don't type in any string, I'll just use the above string as the defalt input ...");
            
            string strFromUser = Console.ReadLine();
            strFromUser.Trim();
            if (strFromUser.Length == 0)
            {
                strFromUser = "Sansa Bran Eddard Stark stark STARK Arya";
            }
            Char delimiter = ' ';
            string [] arraySent = strFromUser.Split(delimiter);
            string[] arrayReturned = sj.stringManipulator( arraySent);
            foreach(string str in arrayReturned)
            {
                if (str != null && str.Trim().Length>0)
                    Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine(".......................Exercise9 End.......................");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
        class Parser
        {
            public static int? ParseInt(string strIn)
            {
                int nRet;
                bool bInt = int.TryParse(strIn, out nRet);
                if (!bInt) return null;
                return nRet;
            }
        }
        static void exercise8()
        {
            Console.Clear();
            Console.WriteLine(".......................Exercise8 start.......................");
            Console.WriteLine(@"
            C# Exercise 8: Create a new branch in your CSharpFoundations repository called C# Exercise #8
            Create a new class called ParserIn your Parser class 
            create a static function called ParseInt that will take a string as a parameter and return a nullable int.  
            Using the int.TryParse method in your ParseInt method, convert the string to an integer and return it.
            If the TryParse returns false then return null from your ParseInt method
            In the main method of your Program class, create and instance of your Parser class. 
            Use the ParseInt method to write the result of parsing “GOT” to the console window.
            Commit and merge your changes to your local repository and Github");
            Console.WriteLine(@"
            type in a string. This string will be converted into int. 
            if the string is not an int, then it will ruturn - This is not an integer value. ");
            string val = Console.ReadLine();
            int? nRet = Parser.ParseInt(val);
            if (nRet.HasValue)
                Console.WriteLine(nRet.ToString() + " - This is an integer.");
            else
                Console.WriteLine(val + " - This is not an integer value.");

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.WriteLine(".......................Exercise8 End.......................");
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
