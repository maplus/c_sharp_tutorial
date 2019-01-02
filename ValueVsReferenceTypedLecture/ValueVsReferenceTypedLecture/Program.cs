using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypedLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3 };
            int[] myArr2;

            myArr2 = myArr;

            Console.WriteLine(myArr2[0]); // 1
            Console.WriteLine(myArr2[1]); // 2
            Console.WriteLine(myArr2[2]); // 3

            myArr2[0] = 7;
            Console.WriteLine(myArr[0]); // 7

            myArr[0] = 1;

            myArr2 = (int[])myArr.Clone();
            myArr2[0] = 7;
            Console.WriteLine(myArr[0]); // 1

            Console.ReadKey();
        }
    }
}
