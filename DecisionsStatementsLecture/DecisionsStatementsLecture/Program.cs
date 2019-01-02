using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionsStatementsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * if ( expression )
             *    // do this
             */

            int age = 20;

            if (age >= 21)
            {
                Console.WriteLine("You are old enough to purchase alcohol.");
                Console.WriteLine("Prost...");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
                Console.WriteLine("Congrats...");
            }
            else
            {
                Console.WriteLine("You are not old enough either to purchase alcohol nor to vote.");
                Console.WriteLine("Sorry...");
            }
                

            Console.WriteLine("Have a nice day.");
            Console.ReadKey();
        }
    }
}
