using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1, i2, i3;
            Console.Write("i1: ");
            i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("i2: ");
            i2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("i3: ");
            i3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: " + Add3(i1, i2, i3));
            Console.ReadKey();
        }

        private static int Add3(int i1, int i2, int i3)
        {
            return i1 + i2 + i3;
        }

        private static void Add3(int i1, int i2, int i3, out int sum)
        {
            sum = i1 + i2 + i3;
        }
    }
}
