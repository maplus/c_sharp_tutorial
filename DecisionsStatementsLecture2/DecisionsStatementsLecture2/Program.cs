using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionsStatementsLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * switch ( variable )
             * {
             *    case value1:
             *       // do this
             *       break;
             *    case value2:
             *       // do this
             *       break;
             *    default:
             *       // do this
             *       break;
             * }
             */

            int doorNumber = 3;

            switch(doorNumber)
            {
                case 1:
                    Console.WriteLine("You win a million dollars!");
                    break;
                case 2:
                    Console.WriteLine("You win a new car!");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("You win nothing.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
