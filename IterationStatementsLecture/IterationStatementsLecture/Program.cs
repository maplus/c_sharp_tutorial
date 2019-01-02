using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * while ( expression )
             * {
             *    // do this
             * }
             */

            int i = 1;
            while (i <= 3)
                Console.WriteLine(i++);
            Console.ReadKey();

            /*
             * do
             * {
             *    // do this
             * }
             * while ( expression );
             */

            i = 1;
            do
                Console.WriteLine(i++);
            while (i <= 3);
            Console.ReadKey();

            /*
             * for ( initialize variable; expression; update variable )
             * {
             *    // do this
             * }
             */

            for (/*int*/ i = 1; i <= 3; ++i)
                Console.WriteLine(i);
            Console.ReadKey();

            for(/*int*/ i = 1; i <= 3; ++i)
            {
                if (i == 1)
                    continue;
                else if (i == 2)
                    break;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
