using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLen = 5;
            string[] groceries = new string[arrLen];
            string substr;
            int count = 0;

            for(int i = 0; i < arrLen; ++i)
            {
                Console.Write($"Enter grocery item {i + 1}: ");
                groceries[i] = Console.ReadLine();
            }

            Console.Write("\nEnter a substring to search for: ");
            substr = Console.ReadLine();

            foreach(String item in groceries)
            {
                if (item.Contains(substr))
                    ++count;
            }

            if (count == 0)
                Console.WriteLine($"There is no element that contains the substring {substr}.");
            else if (count == 1)
                Console.WriteLine($"There is {count} element that contains the substring {substr}.");
            else
                Console.WriteLine($"There are {count} elements that contain the substring {substr}.");

            Console.ReadKey();
        }
    }
}
