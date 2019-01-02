using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParametersLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 5; // must be initialized because of ref...
            int x; // must NOT be initialized because of out...

            ChangeNumber(ref w, out x);

            Console.WriteLine(w + ", " + x); // 0, -1
            Console.ReadKey();
        }

        private static void ChangeNumber(ref int y, out int z)
        {
            y = 0;
            z = -1;
        }
    }
}
