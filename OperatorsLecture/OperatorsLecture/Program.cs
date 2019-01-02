using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %

            int x = 1, y = 1, sum;
            sum = x + y; // 2

            double d1 = 5.0 / 2.0; // 2.5
            double d2 = 5 / 2; // 2

            int remainder;
            remainder = 7 % 3; // 1
            remainder = 6 % 3; // 0

            y = 1;
            x = ++y; // x = 2; y = 2

            y = 2;
            x = --y; // x = 1; y = 1

            y = 1;
            x = y++; // x = 1; y = 2

            y = 2;
            x = y--; // x = 2; y = 1

            x += y;
            x -= y;
            x *= y;
            x /= y;

            sum = 1 + 2 * 5; // 11

            /*
             * HIGHEST PRECEDENCE
             * ++, -- (prefix)
             * *, /, %
             * +, -
             * =, +=, -=, *=, /=
             * ++, -- (postfix)
             * LOWEST PRECEDENCE
             */

            sum = (1 + 2) * 5; // 15

            string s1 = "pro";
            string s2 = "gramming";
            Console.WriteLine(s1 + s2); // out: programming

            Console.ReadKey();
        }
    }
}
