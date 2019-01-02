using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationsLecture
{
    class Program
    {
        //enum DayOfWeek { Monday, Tuesday = 5, Wednesday, Thursday, Friday, Saturday, Sunday };
        enum DayOfWeek : byte { Monday, Tuesday = 5, Wednesday, Thursday, Friday, Saturday, Sunday };

        static void Main(string[] args)
        {
            DayOfWeek currentDay;

            //currentDay = DayOfWeek.Teusday; // Compile Error.
            currentDay = DayOfWeek.Tuesday;

            Console.WriteLine(currentDay); // Tuesday.
            Console.WriteLine((int)currentDay); // 1.


            currentDay = DayOfWeek.Monday;

            Console.WriteLine(currentDay); // Tuesday.
            Console.WriteLine((int)currentDay); // 1.


            currentDay = DayOfWeek.Wednesday;

            Console.WriteLine(currentDay); // Tuesday.
            Console.WriteLine((int)currentDay); // 1.


            Console.ReadKey();
        }
    }
}
