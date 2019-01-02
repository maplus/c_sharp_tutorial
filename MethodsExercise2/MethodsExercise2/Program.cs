using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Enter an integer (1 to exit): ");
                number = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(number))
                {
                    Console.WriteLine("It is a prime number :)");
                }
                else
                {
                    Console.WriteLine("It is not a prime number :(");
                };
                Console.WriteLine();
            } while (number != 1);
        }

        private static bool IsPrime(int v)
        {
            bool isPrime = true;

            for(int i = 2; i < v; ++i)
            {
                if(v % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
