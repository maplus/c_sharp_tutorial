using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            byte selection = 0;

            do
            {
                Console.WriteLine("Choose an option from the menu:");
                Console.WriteLine("1 - Enter product");
                Console.WriteLine("2 - Diplay Inventory");
                Console.WriteLine("3 - Exit");

                selection = Convert.ToByte(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Product p = new Product();
                        p.InputInfo();
                        Inventory.AddProduct(p);
                        break;
                    case 2:
                        Inventory.DisplayInventory();
                        break;
                }

                Console.WriteLine();
            } while (selection != 3);
        }
    }
}
