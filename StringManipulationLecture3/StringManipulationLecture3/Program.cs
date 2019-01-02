using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;

            myString = "abc";
            Console.WriteLine(myString.Length); // 3

            myString = "I am learning C#.";
            Console.WriteLine(myString.ToLower()); // i am learning c#
            Console.WriteLine(myString.ToUpper()); // I AM LEARNING C#

            myString = "This is fun!";
            Console.WriteLine(myString.Contains("fun")); // True
            Console.WriteLine(myString.Contains("boring")); // False

            Console.WriteLine(myString.Substring(5)); // is fun!
            Console.WriteLine(myString.Substring(5, 2)); // is

            Console.WriteLine(myString.Remove(5)); // "This "
            Console.WriteLine(myString.Remove(5, 2)); // This  fun!

            Console.WriteLine(myString.Replace("fun", "awesome")); // This is awsome!

            int myInt = 5;
            double myDouble = 5.44735453;
            bool myBool = false;

            Console.WriteLine(myInt/*.ToString()*/); // 5
            Console.WriteLine(myDouble/*.ToString("F")*/); // 5,44735453
            Console.WriteLine(myBool/*.ToString()*/); // False

            Console.ReadKey();
        }
    }
}
