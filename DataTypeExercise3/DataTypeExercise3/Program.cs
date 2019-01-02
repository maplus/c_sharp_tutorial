using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExercise3
{
    enum Directions { North, South, East, West }
    class Program
    {
        static void Main(string[] args)
        {
            List<Directions> directions = new List<Directions>();
            char input;

            do
            {
                Console.Write("Enter the next direction (n/s/e/w or 0 to finish): ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (input)
                {
                    case 'n':
                        directions.Add(Directions.North);
                        break;
                    case 's':
                        directions.Add(Directions.South);
                        break;
                    case 'e':
                        directions.Add(Directions.East);
                        break;
                    case 'w':
                        directions.Add(Directions.West);
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (input != '0');

            Console.WriteLine($"\nYou entered {directions.Count} directions. The directions are as follows:");
            foreach (Directions d in directions)
                Console.Write($"{GetSymbol(d)} ");

            Console.ReadKey();
        }

        static string GetSymbol(Directions d)
        {
            switch (d)
            {
                case Directions.North:
                    return "^";
                case Directions.South:
                    return "v";
                case Directions.East:
                    return ">";
                case Directions.West:
                    return "<";
                default:
                    return "";
            }
        }
    }
}
