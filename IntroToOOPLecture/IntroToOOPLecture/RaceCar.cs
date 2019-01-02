using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOPLecture
{
    class RaceCar : Car
    {
        private int numNitros;

        public RaceCar(int numNitros) : base()
        {
            this.numNitros = numNitros;
        }

        public RaceCar(string color, string brand, int numNitros) : base(color, brand)
        {
            this.numNitros = numNitros;
        }

        public void UseNitro()
        {
            if (numNitros > 0)
            {
                ChangeSpeed(20);
                --numNitros;
            }
            else
                Console.WriteLine("Out of nitro!");
        }

        public override void DisplayInfo()
        {
            //base.DisplayInfo();
            Console.WriteLine($"The {Color} {Brand} ist travelling at {CurrentSpeed} km/h and has {numNitros} nitro(s) left.");
        }
    }
}
