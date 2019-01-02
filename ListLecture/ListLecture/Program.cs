using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            bool contains;
            int idx;
            List<string> starTreckChars = new List<string>();

            starTreckChars.Add("Kirk"); // Idx 0.
            starTreckChars.Add("Spock"); // Idx 1.
            starTreckChars.Add("McCoy"); // Idx 2.

            starTreckChars.Insert(2, "Scotty"); // Scotty idx 2, McCoy idx 3.

            starTreckChars.RemoveAt(2); // McCoy idx 2.

            starTreckChars.Remove("Spock"); // McCoy idx 1.

            string fstChar = starTreckChars[0];

            starTreckChars[0] = "Picard";

            Console.WriteLine(fstChar);

            foreach (string starTreckChar in starTreckChars)
                Console.WriteLine(starTreckChar);

            Console.WriteLine("--------------------");

            starTreckChars.Clear();

            starTreckChars.Add("Kirk");
            starTreckChars.Add("Spock");
            starTreckChars.Add("Picard");
            starTreckChars.Add("McCoy");

            Console.WriteLine(starTreckChars.Count + "\n");

            contains = starTreckChars.Contains("Kirk"); // True.
            contains = starTreckChars.Contains("Scotty"); // False.

            idx = starTreckChars.IndexOf("Kirk"); // 0.
            idx = starTreckChars.IndexOf("Scotty"); // -1.

            foreach (string starTreckChar in starTreckChars)
                Console.WriteLine(starTreckChar);
            Console.WriteLine();

            starTreckChars.Sort();

            foreach (string starTreckChar in starTreckChars)
                Console.WriteLine(starTreckChar);
            Console.WriteLine();

            starTreckChars.Reverse();

            foreach (string starTreckChar in starTreckChars)
                Console.WriteLine(starTreckChar);

            Console.ReadKey();
        }
    }
}
