using System;

namespace DebuggingLecture
{
    internal class Car
    {
        public string color;
        public string brand;
        public int currentSpeed;

        public Car(string color, string brand)
        {
            this.color = color;
            this.brand = brand;
            currentSpeed = 0;
        }

        internal void Accelerate(int speedIncrease)
        {
            currentSpeed += speedIncrease;
        }

        internal void Decelerate(int speedDecrease)
        {
            currentSpeed -= speedDecrease;
        }

        public void DisplaySpeed()
        {
            Console.WriteLine($"The {color} {brand} is travelling at {currentSpeed} km/h");
        }
    }
}