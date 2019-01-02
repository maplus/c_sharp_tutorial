using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroMethodsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * returnType Name( parameters )
             * {
             *    // do this
             * }
             */

            Console.WriteLine("You are learning how to program.");
            PrintCongrats();

            Console.WriteLine("You are doing so well.");
            PrintCongrats();

            Console.WriteLine("You are going to be rich.");
            PrintCongrats();

            Console.ReadKey();
        }

        private static void PrintCongrats()
        {
            Console.WriteLine("Congratulations!");
        }
    }
}
