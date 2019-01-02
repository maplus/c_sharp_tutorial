using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string likesPizza;
            bool isResponseValid = false;

            do
            {
                Console.Write("Do you like pizza? (yes/no): ");
                likesPizza = Console.ReadLine();

                if("yes".Equals(likesPizza))
                {
                    isResponseValid = true;
                    Console.WriteLine("You like pizza :)");
                }
                else if ("no".Equals(likesPizza))
                {
                    isResponseValid = true;
                    Console.WriteLine("You do not like pizza :(");
                }
                else
                {
                    isResponseValid = false;
                    Console.WriteLine("You did not enter a valid response, please try again...");
                    Console.WriteLine();
                }
            } while (!isResponseValid);
            Console.ReadKey();
        }
    }
}
