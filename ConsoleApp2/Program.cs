using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {
            TroublesomeVariableScope.SetMeUp();
            MissingItemExercise.SetMeUp();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
    public static class TroublesomeVariableScope
    {
        public static void SetMeUp() {
            // create actions..
            var actions = new List<Action>();
            for (var index = 1; index <= 10; index++)
            {
                var local = index; //<<<----THIS IS THE CORRECTION...
                // define new action..
                Action action = () =>
                {
                    // output the value of index.
                    // var local = index;<<<<-------THIS WAS THE OFFENDING CODE...this variable is declare in the wrong place...see above
                    Console.WriteLine(local);
                }

                    ;
                // add action to list.
                actions.Add(action);
            }

            // Execute actions..
            foreach (var action in actions)
            {
                action();
            }

        }
        
    }

    public static class MissingItemExercise {
        //Sum of the First n Terms of an Arithmetic Sequence
        //Sum = (n(a1 + an))/2
        //iterate through each of the provided sequence...substracting each item from sum... 
        //tbe remainder is the missing number...
        //tbe nth term in the sequence is a1 +(n-1)d...
        
        public static void SetMeUp()
        {
            var lower = 1;
            var upper = 100;
            var missing = 100;//7;
            var x = Enumerable.Range(lower, upper).Except(Enumerable.Range(missing, 1)).ToArray();
            var ms = MissingNumber(x, lower, upper).ToString();
            Console.WriteLine("Hello " + ms + "  is missing...");
            
        }
        private static int MissingNumber(int[] numbers, int min, int max)
        {
            //Sum of the First n Terms of an Arithmetic Sequence
            //Sum = (n(a1 + an))/2
            int expectedSum = (min + max) * (numbers.Length + 1) / 2;
            int actualSum = numbers.Sum();
            int missingNumber = expectedSum - actualSum;

            return missingNumber;
        }
        private static int XORMissingNumber(int[] numbers, int min, int max)
        {
            return 2;

        }

    }

    public static class DubyaFizzBuzz
    {
        public static string MyFizzBuss()
        {
            string rslt = "";
            for (int i = 1; i <= 100; i++)
            {
                rslt += i.ToFizzBuzzVal(); //as an extension of int
                //switch (i)
                //{
                //    case int n when (n % 3 == 0 && n % 5 == 0):// or % 15
                //        rslt += "FizzBuzz ";
                //        break;
                //    case int n when (n % 3 == 0):
                //        rslt += "Fizz ";
                //        break;
                //    case int n when (n % 5 == 0):
                //        rslt += "Buzz ";
                //        break;
                //    default:
                //        rslt += i.ToString() + " ";
                //        break;
                //}
            }

            return rslt;
        }

        public static string ToFizzBuzzVal(this int value)
        {
            var is3 = value % 3 == 0;
            var is5 = value % 5 == 0;
            if (is3 || is5)
            {
                if (is3 && !is5)
                {
                    return "Fizz ";
                }
                else if (!is3)
                {
                    return "Buzz ";//is5
                }
                else
                {
                    return "FizzBuzz ";
                }

                //switch (true)
                //{
                //    case bool n when (is3 && is5):
                //        rslt = "FizzBuzz ";
                //        break;
                //    case bool n when (is3):
                //        rslt = "Fizz ";
                //        break;
                //    case bool n when (is5):
                //        rslt = "Buzz ";
                //        break;
                //}
            }
            else
            {
                return value.ToString() + " ";
            }
        }
    }

    public static class DubyaLeapYear
    {

        public static string TestLeapYear(int lower, int upper)
        {
            string rslt = "";
            for (var i = lower; i <= upper; i++)
            {
                var isLy = i.IsLeapYear();
                if (isLy)
                {
                    rslt += i.ToString() + ": " + isLy.ToString() + ";  "; //as an extension of int
                }
            }
            return rslt;
        }

        public static bool IsLeapYear(this int value)
        {
            var rslt = false;

            var isDiv4 = value % 4 == 0;
            var isDiv100 = value % 100 == 0;
            var isDivAlso400 = (isDiv100 && value % 400 == 0);
            rslt = isDiv4 && ((!isDiv100) || isDivAlso400);

            return rslt;
        }
    }
}
