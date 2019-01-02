using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    static class Inventory
    {
        private static List<Product> products;

        static Inventory()
        {
            products = new List<Product>();
        }

        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        public static void DisplayInventory()
        {
            double totalInventoryValue = 0;
            Console.WriteLine("Current inventory:");
            Console.WriteLine("***********************************************\n");
            foreach(Product p in products)
            {
                p.DiplayInfo();
                Console.WriteLine();
                totalInventoryValue += p.TotalValue();
            }
            Console.WriteLine($"Total inventory value: {totalInventoryValue.ToString("F")}");
            Console.WriteLine("***********************************************\n");
        }
    }
}
