using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPLecture
{
    class PickupTruck : Car
    {
        public int bedLen;

        public PickupTruck(int bedLen) : base()
        {
            this.bedLen = bedLen;
        }

        public PickupTruck(string color, string brand, int bedLen) : base(color, brand)
        {
            this.bedLen = bedLen;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"The {Color} {Brand} ist travelling at {CurrentSpeed} km/h and has a bed length of {bedLen}.");
        }
    }
}
