using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_CodeAlong
{
    internal class Bil
    {
        public string Car;
        public int Speed;
        public int MinSpeed;    
        public int TopSpeed;
        public int MileAge;

        public Bil(string car, int speed, int minSpeed, int topSpeed, int mileAge)
        {
            Car = car;
            Speed = speed;
            MinSpeed = minSpeed;
            TopSpeed = topSpeed;
            MileAge = mileAge;
        }

        public void RunCar()
        { 
            MileAge = 0;
            Speed = 10;

            while (MileAge <= 1000)
            {
                if (MileAge == 0 || MileAge < 500)
                {
                    Speed += 10;
                    Console.WriteLine("Speed opp");
                }
                else if (MileAge <= 1000 && Speed >= 10)
                {
                    Speed -= 10;
                    Console.WriteLine("Speed ned");
                }
                else
                {
                    Speed = 10;
                }
                MileAge += 10;
            }
            Console.WriteLine("Bilen er parkert og du er fremme.");
        }
    }
}
