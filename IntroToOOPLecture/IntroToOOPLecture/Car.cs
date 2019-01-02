using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPLecture
{
    /*abstract*/ class Car // Cannot create an instance of the abstract class or interface!!!
    {
        //private static int numCardObjects = 0;
        // protected modifier is for get access on derived classes!!!
        public static int NumCardObjects { get/* => numCardObjects*/; set; }
        public string Color { get; set; }
        string brand;
        public string Brand
        {
            get { return brand; }
            set {
                if (IsBrandValid(value))
                    brand = value;
                else
                    Console.WriteLine("Invalid brand");
            }
        }
        public int CurrentSpeed { get; set; }

        public Car()
        {
            CurrentSpeed = 0;
            ++NumCardObjects;
        }

        public Car(string color, string brand)
        {
            Color = color;
            Brand = brand;
            CurrentSpeed = 0;
            ++NumCardObjects;
        }

        public void ChangeSpeed(int speedIncrease)
        {
            CurrentSpeed += speedIncrease;
        }

        public virtual void DisplayInfo() // Allows overriding.
        {
            Console.WriteLine($"The {Color} {Brand} is travelling at {CurrentSpeed} km/h.");
        }

        List<string> brands = new List<string>{ "Toyota", "Honda", "Ford" };
        private bool IsBrandValid(string brand)
        {
            if (brands.Contains(brand))
                return true;
            else
                return false;
        }
    }
}
