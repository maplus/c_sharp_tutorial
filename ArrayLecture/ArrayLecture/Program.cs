using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumArray = { 2, 5, 9 };
            int[] myNumArray2 = new int[3];

            Console.WriteLine(myNumArray[0]); // 2

            myNumArray[1] = 12; // Replaces the 5 stored in index 1.

            for(int i = 0; i < myNumArray.Length; ++i)
                Console.WriteLine(myNumArray[i]);

            foreach(int i in myNumArray)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
