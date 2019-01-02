using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPLecture
{
    class Lamp
    {
        // Fields.
        public string color;
        public bool isOn;

        public void TurnOn()
        {
            isOn = true;
        }

        public void TurnOff()
        {
            isOn = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp1 = new Lamp();
            Lamp lamp2 = new Lamp();
            Lamp lamp3 = new Lamp();

            lamp1.color = "green";
            lamp1.isOn = true;

            lamp1.color = "blue";
            lamp1.isOn = false;

            lamp1.color = "red";
            lamp1.isOn = true;

            Console.WriteLine(lamp1.isOn); // True.
            lamp1.TurnOff();
            Console.WriteLine(lamp1.isOn); // False.

            Console.ReadKey();

            Math.Round(4.43242); // Static class >> contains only static methods.

            Console.WriteLine(Car.NumCardObjects); // 0.
            Car car1 = new Car();
            Console.WriteLine(Car.NumCardObjects); // 1.
            Car car2 = new Car("green", "Honda");
            Console.WriteLine(Car.NumCardObjects); // 2.

            car1.Color = "red";
            car1.Brand = "Toyota";

            car1.ChangeSpeed(20);
            car2.ChangeSpeed(20);
            car2.ChangeSpeed(-10);

            car1.DisplayInfo();
            car2.DisplayInfo();

            Console.ReadKey();

            RaceCar myRaceCar = new RaceCar(5);
            myRaceCar.UseNitro();
            myRaceCar.ChangeSpeed(-5);
            myRaceCar.DisplayInfo();

            RaceCar myRaceCar2 = new RaceCar("red", "Toyoya", 5);
            
            PickupTruck myPicupTruck = new PickupTruck("white", "Ford", 100);
            myPicupTruck.DisplayInfo();

            Console.ReadKey();
        }
    }
}
