﻿/*
 * Exercise File
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CSharpFoundations
{
    class Program
    {
        public List<int> MakeCollection(int start, int end)
        {
            List<int> lstOut = new List<int>();
            while (start < end)
            {
                lstOut.Add(start++);
            }
            return lstOut;
        }
        public static List<double> GetDebits(List<double> lstIn)
        {
            List<double> q = new List<double>();
            var ms = lstIn.Where(inte => inte < 0)
                    .Select(inte => inte);
            foreach (var m in ms)
            {
                q.Add(m);
            }
            return q;
        }
        public class internalProtectedPublicAndPrivate
        {
            internal int iNternal = 0;
            protected int pRotected = 0;
            private int pRivate = 0;
            public int pUblic = 0;
        }
        static void Main(string[] args)
        {
            //TypeConversion();
            //parent p = new parent();
            //Console.WriteLine(p.name());
            //parent cASp = new child();
            //Console.WriteLine(cASp.name());
            List<double> lstIn = new List<double>();
            lstIn.Add(3.5);
            lstIn.Add(-3.1);
            lstIn.Add(0.5);
            lstIn.Add(-2.5);
            lstIn.Add(-7.5);

            List<double> lOut = GetDebits(lstIn);
            child cASc = new child();
            Console.WriteLine(cASc.name);
            cASc.abstractMethod();
            cASc.CallVirtualMethod();
            Zebra z = new Zebra();
            z.Eat();
            z.getGlitters();
            internalProtectedPublicAndPrivate ccc = new internalProtectedPublicAndPrivate();
          


            Console.WriteLine(".......................temp inheritance s End.......................");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            //RepeatIt();
            //int.TryParse()
        }

        static void RepeatIt()
        {
            DateTime dtThen = DateTime.Now.AddYears(65 - 25);
            //DateTime dt = new DateTime(DateTime.Now+65-25)
            Console.Clear();
            Console.WriteLine(@"
                The time then will be " + dtThen.ToLongDateString() + ":" + dtThen.ToLongTimeString() +
                @"
                The time now is " + DateTime.Now.ToLongDateString() + ":" + DateTime.Now.ToLongTimeString() 
                + @" 
            .......................Exercises start.......................
            It is 
            press 1 for exercise1 (under construction)
            press 2 for exercise2 (under construction)
            press 3 for exercise3 - StringBuilder and the FizzBuzz program
            press 4 for exercise4 - nullable value-type varibale declarable (e.g. int? and HasValue)
            press 5 for exercise5 - building a string array with the primitive way (e.g. string[] s = {""svs"");)
            press 6 for exercise6 - use Convert.ToDateTime
            press 7 for exercise7 - static methods and non-static methods
            press 8 for exercise8 - usge of int.TryParse
            press 9 for exercise9 - StarkJumper (create a new string array and exclude a specific string such as Stark
            press A for exercise10 - ParseDouble and try..catch
            press B for exercise11 - experiment
            press C for exercise12 - Converter - This demonstrates static classes
            press D for exercise11_fromClass - Jagged Arrays
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
            if (myKey == ConsoleKey.A) { exercise10(); RepeatIt(); }
            if (myKey == ConsoleKey.B) { exercise11(); RepeatIt(); }
            if (myKey == ConsoleKey.C) { exercise12(); RepeatIt(); }
            if (myKey == ConsoleKey.D) { exercise11_fromclass(); RepeatIt(); }
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

        static void exercise11_fromclass()
        {
            Console.Clear();
            Console.WriteLine(".......................exercise11_fromclass start.......................");
            Console.WriteLine(@"
            C# Exercise 11: Create a new branch in your CSharpFoundations repository called C# Exercise #11
            Remove all of the code from your Program.Main method
            Create a Jagged Array of at least 3 Game of Thrones houses with at least 2 character names from that house (arrays of names inside of an array of houses)
            Use loops to write to the console window each house and their character names
            Commit and merge your changes to your local repository and Github
            ");

            string[][] arrayOfHouses = new string[3][];

            arrayOfHouses[0] = new string[3];
            arrayOfHouses[1] = new string[3];
            arrayOfHouses[2] = new string[3];

            arrayOfHouses[0][0] = "House Stark";
            arrayOfHouses[0][1] = "Eddard (Ned) Stark";
            arrayOfHouses[0][2] = "Catelyn Stark";

            arrayOfHouses[1][0] = "House Lannister";
            arrayOfHouses[1][1] = "Tywin Lannister";
            arrayOfHouses[1][2] = "Cersei Lannister";

            arrayOfHouses[2][0] = "House Baratheon";
            arrayOfHouses[2][1] = "Robert Baratheon";
            arrayOfHouses[2][2] = "Stannis Baratheon";

            foreach (string[] arr in arrayOfHouses)
            {
                Console.WriteLine("House Name ------" + arr[0]);
                Console.WriteLine("House residents - ({0}) and ({1})", arr[1], arr[2] );
                Console.WriteLine("-------- ------");
            }

            


            Console.WriteLine(".......................Exercise12 End.......................");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }

        static void exercise12()
        {
            Console.Clear();
            Console.WriteLine(".......................Exercise12 start.......................");
            Console.WriteLine(@"
            ");
            Console.WriteLine("Enter FarenHeight number (default is 32) = ");
            string strFarenheight = Console.ReadLine();
            if (strFarenheight.Trim().Length == 0) strFarenheight = "32";
            double dblFarenheight = Convert.ToDouble(strFarenheight);
            double dblCelsius = Converter.FarennheightToCelsius(dblFarenheight);

            Console.WriteLine("You Entered {0} Farenheights and the converter class converted it to celsius = {1}     ",
                dblFarenheight.ToString(),
                dblCelsius.ToString());

            Console.WriteLine("Now Enter Celsius number (default is 0) = ");
            string strCelsius = Console.ReadLine();
            if (strCelsius.Trim().Length == 0) strCelsius = "0";
            dblCelsius = Convert.ToDouble(strCelsius);
            dblFarenheight = Converter.CelsiusToFarennheight(dblCelsius);
            Console.WriteLine("You Entered {0} strCelsius and the converter class converted it to FarenHeight = {1}     " ,
                dblCelsius.ToString(),
                dblFarenheight.ToString());

            Console.WriteLine(".......................Exercise12 End.......................");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
        static public string[] SwapFirstAndLast(string[] arr)
        {
            string[] strArray = new string[arr.Length];
            for (int i = 1; i < arr.Length - 1; i++)
            {
                strArray[i] = arr[i];
            }
            strArray[0] = arr[arr.Length - 1];
            strArray[arr.Length - 1] = arr[0];
            return strArray;
        }
        static void exercise11()
        {
            Console.Clear();
            Console.WriteLine(".......................Exercise11 start.......................");
            Console.WriteLine(@"
            ");
            string strFromUser = "svs is mad in c#";
            Char delimiter = ' ';
            string[] arraySent = strFromUser.Split(delimiter);
            string[] arrayReturned = SwapFirstAndLast(arraySent);
            Console.WriteLine(strFromUser);
            foreach(string s in arrayReturned)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(".......................Exercise11 End.......................");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }

        class NumberValidator
        {
            public double ParseDouble(string strDouble)
            {
                double dblRet = 0;
                try
                {
                    dblRet = double.Parse(strDouble);
                }
                catch(Exception ex)
                {
                    throw ex;
                }                   
                return dblRet;
            }
        }
        static void exercise10()
        {
            Console.Clear();
            Console.WriteLine(".......................Exercise10 start.......................");
            Console.WriteLine(@"
            C# Exercise 10: Create a new branch in your CSharpFoundations repository called C# Exercise #10
            Create a new class called NumberValidator
            Add a method to the NumberValidator class called ParseDouble that takes a string as a parameter and returns a double
            In the ParseDouble method use the double.Parse method to return the string as a double.  
            Use the Try/Catch block to catch an exception and re-throw the error as a System.Exception error instead of the original error
            Commit and merge your changes to your local repository and Github
            ");
            Console.WriteLine(@"
                Enter a number in double format. e.g. 1000.667. This value is default unless provided.  ");
            string dblValue = Console.ReadLine();
            if (dblValue.Trim().Length <=0) 
            {
                dblValue = "1000.667";
            }
            NumberValidator nv = new NumberValidator();
            try
            {
                double dbl = nv.ParseDouble(dblValue);
                Console.WriteLine("You entered {0} and it is indeed a double. The parsed value is {1}", dblValue, dbl.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("You entered {0} and it is NOT a double. The parser threw exception...   {1} {2}", dblValue, System.Environment.NewLine,  ex.ToString());
            }           
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
