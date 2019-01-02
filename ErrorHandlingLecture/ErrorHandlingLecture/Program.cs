using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3 };

            /*            int selection;
                        Console.Write("Enter the array index of the element you wish to view: ");
                        selection = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(myArr[selection]);*/

            string selection;
            int parsedInt;
            bool error = false;

            do // v1.
            {
                Console.Write("Enter the array index of the element you wish to view: ");
                selection = Console.ReadLine();
                if(int.TryParse(selection, out parsedInt))
                {
                    if(parsedInt >= 0 && parsedInt < myArr.Length)
                    {
                        error = false;
                        Console.WriteLine(myArr[parsedInt]);
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine($"{selection} is not a valid index for the array. Please try again.");
                    }
                }
                else
                {
                    error = true;
                    Console.WriteLine($"{selection} is not an integer. Please try again.");
                }
            } while (error);

            Console.ReadKey();

            int selection2; // v2.
            do
            {
                error = false;
                try
                {
                    Console.Write("Enter the array index of the element you wish to view: ");
                    selection2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(myArr[parsedInt]);
                }
                catch (Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message + " Please try again");
                }
            } while (error);

            Console.ReadKey();

            Console.Write("Enter an integer between 1-100: "); // v3.
            try
            {
                selection2 = Convert.ToInt32(Console.ReadLine());
                if (selection2 < 1 || selection2 > 100)
                    throw new IndexOutOfRangeException($"Invalid input. {selection2} is not between 1-100.");

                Console.WriteLine();
                Console.WriteLine($"You entered {selection2}");
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
