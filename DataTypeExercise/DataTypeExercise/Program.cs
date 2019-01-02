using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            string item = null;

            Console.WriteLine("Enter as much items as you want or end with 'fin'");
            do
            {
                Console.Write("Item: ");
                item = Console.ReadLine();

                if(!item.Equals("fin"))
                    items.Add(item);

            } while(!item.Equals("fin"));

            Console.WriteLine();
            Console.WriteLine("List you entered:");
            foreach(string s in items)
                Console.WriteLine("\t" + s);

            Console.ReadKey();
        }
    }
}
