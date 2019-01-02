using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningPassingDataLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are learning how to program.");
            Console.WriteLine(ReturnCongrats());

            Console.WriteLine("You are doing so well.");
            Console.WriteLine(ReturnCongrats());

            Console.WriteLine("You are going to be rich.");
            Console.WriteLine(ReturnCongrats());

            Console.ReadKey();
        }

        private static string ReturnCongrats()
        {
            return "Congratulations!";
        }
    }
}
