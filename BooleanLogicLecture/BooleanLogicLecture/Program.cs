using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = false;
            Console.WriteLine(answer);

            /*
             * BOOLEAN OPERATORS
             * == Equality
             * != Inequality
             * !  Not
             * >  Greater than
             * <  Less than
             * >= Greater than or equal to
             * <= Less than or equal to
             * && Logical And
             * || Logical Or
             */

            answer = 1 == 1; // true
            answer = 1 != 2; // true
            answer = !false; // true

            answer = 2 > 1; // true
            answer = 1 < 2; // true
            answer = 2 >= 1; // true
            answer = 2 >= 2; // true
            answer = 1 <= 2; // true
            answer = 2 <= 2; // true

            answer = true && true; // true
            answer = true && false; // false
            answer = false && false; // false

            answer = true || true; // true
            answer = true || false; // true
            answer = false || false; // false

            Console.ReadKey();
        }
    }
}
