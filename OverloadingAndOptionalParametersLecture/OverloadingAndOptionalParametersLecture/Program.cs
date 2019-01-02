using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAndOptionalParametersLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultinteger;
            double resultDouble;

            resultinteger = NumbersAdded(2, 3);
            resultDouble = NumbersAdded(4.3, 7.9);
            resultinteger = NumbersAdded(7, 2, 4);

            Console.WriteLine(resultinteger);
            Console.WriteLine(resultDouble);

            Console.WriteLine(RaiseToPower(2)); // 4
            Console.WriteLine(RaiseToPower(2, 3)); // 8

            Console.ReadKey();
        }

        private static int NumbersAdded(int x, int y)
        {
            return x + y;
        }
        private static double NumbersAdded(double x, double y)
        {
            return x + y;
        }
        private static int NumbersAdded(int x, int y, int z)
        {
            return x + y + z;
        }

        private static int RaiseToPower(int baseNumber, int power = 2) // Mandatory parameters first, optional parameter at the end.
        {
            int result = 1;

            for (int i = 1; i <= power; ++i)
            {
                result *= baseNumber;
            }

            return result;
        }
    }
}
