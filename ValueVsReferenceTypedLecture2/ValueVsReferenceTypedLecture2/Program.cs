using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypedLecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3 };

            someMethod(myArr);
            Console.WriteLine(myArr[0]); // 7

            myArr[0] = 1;

            someMethod2(myArr);
            Console.WriteLine(myArr[0]); // 1

            someMethod3(ref myArr);
            Console.WriteLine(myArr[0]); // 0

            Console.ReadKey();
        }

        private static void someMethod(int[] myArr2)
        {
            myArr2[0] = 7;
        }

        private static void someMethod2(int[] myArr2)
        {
            myArr2 = new int[3];
        }

        private static void someMethod3(ref int[] myArr2)
        {
            myArr2 = new int[3];
        }
    }
}
