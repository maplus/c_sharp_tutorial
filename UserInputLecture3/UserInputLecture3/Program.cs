using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("Enter some text: ");
            userInput = Console.ReadLine();

            Console.WriteLine("You entered: " + userInput);
            Console.ReadKey();
        }
    }
}
