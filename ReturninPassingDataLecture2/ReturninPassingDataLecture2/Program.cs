using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturninPassingDataLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            result = NumberSquared(4);
            Console.WriteLine(result); // 16

            result = NumbersAdded(2, 3);
            Console.WriteLine(result); // 5

            Console.ReadKey();
        }

        private static int NumberSquared(int v)
        {
            return v * v;
        }

        private static int NumbersAdded(int x, int y)
        {
            return x + y;
        }
    }
}
