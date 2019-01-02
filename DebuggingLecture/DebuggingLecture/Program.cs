using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;

            Car car1 = new Car("red", "Toyota");

            myInt = 7;

            car1.Accelerate(20);
            car1.Decelerate(10);

            if (myInt > 5)
                Console.WriteLine(myInt);

            Console.ReadKey();
        }
    }
}
