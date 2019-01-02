using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndErrorHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sales = new double[4];
            double totalSales = 0;
            double totalExpenses;
            double profit;
            double avgProfitPerDistrict;

            // Input sales from each of the four districts.
            for(int i = 0; i < sales.Length; ++i)
            {
                Console.Write($"Enter sales from district {i + 1}: ");
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Enter total expenses: ");
            totalExpenses = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // Calculates total sales.
            foreach(double d in sales)
            {
                totalSales += d;
            }

            // Calculates profit.
            profit = totalSales - totalExpenses;

            // Calculates avg profit per district.
            avgProfitPerDistrict = profit / sales.Length;

            Console.WriteLine($"Avg profit per district was {avgProfitPerDistrict.ToString("F")}");

            Console.ReadKey();
        }
    }
}
