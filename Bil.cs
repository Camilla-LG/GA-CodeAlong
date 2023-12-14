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
    }
}
