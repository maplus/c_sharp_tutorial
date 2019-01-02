using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int userAge;
            string friendName;
            int friendAge;

            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + userName + " and you are " + userAge + " years old");
            Console.WriteLine();

            Console.Write("Enter your friend's name: ");
            friendName = Console.ReadLine();
            Console.Write("Enter your friend's age: ");
            friendAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your friend's name is " + friendName + " and he is " + friendAge + " years old");
            Console.WriteLine();

            Console.WriteLine("There are " + (userAge - friendAge) + " years between the two of you");

            Console.ReadKey();
        }
    }
}
