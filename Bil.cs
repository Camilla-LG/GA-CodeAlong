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
        public int MileAge;

        public Bil(string car, int speed, int mileAge)
        {
            Car = car;
            Speed = speed;
            MileAge = mileAge;
        }

        public void RunCar()
        { 
            MileAge = 0;
            Speed = 10;

            Console.WriteLine("God tur!");

            while (MileAge <= 1000)
            {
                if (MileAge == 0 || MileAge <= 500)
                {
                    Speed += 10;

                    if (MileAge == 500) 
                    {
                        Console.WriteLine("Du er halvveis, på tide å slakke ned farta");
                    }
                }
                else if (MileAge <= 1000 && Speed >= 10)
                {
                    Speed -= 10;
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
