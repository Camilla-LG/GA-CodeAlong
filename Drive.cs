using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_CodeAlong
{
    public class Drive
    { 
      
        public void RunCar(Vehicle vehicle)
        {

            Console.WriteLine("God tur!");

            while (vehicle.MileAge <= 1000)
            {
                if (vehicle.MileAge <= 500)
                {
                    vehicle.Speed += 10;

                    if (vehicle.MileAge == 500)
                    {
                        Console.WriteLine("Du er halvveis, på tide å slakke ned farta");
                    }
                }
                else if (vehicle.MileAge <= 1000 && vehicle.Speed >= 10)
                {
                    vehicle.Speed -= 10;
                }
                vehicle.MileAge += 10;
            }
            Console.WriteLine("Bilen er parkert og du er fremme.");
        }

        public void CarRace(Vehicle vehicle)
        {
            Random random = new Random();
            vehicle.AddCarsToList();

            var car1index = random.Next(0, vehicle.cars.Count);
            var car2index = random.Next(0, vehicle.cars.Count);

            var car1name = vehicle.GetCarNameAtIndex(car1index);
            var car1mileage = vehicle.GetMileageAtIndex(car1index);
            var car1speed = vehicle.GetSpeedAtIndex(car1index);
            var car2name = vehicle.GetCarNameAtIndex(car2index);
            var car2mileage = vehicle.GetMileageAtIndex(car2index);
            var car2speed = vehicle.GetSpeedAtIndex(car2index);

            Console.WriteLine("Velkommen til RaceWars!");

            Console.WriteLine($"Du kjører {car1name} mot {car2name}!");
            Console.WriteLine("KJØØØØØØR!");
            Console.WriteLine();
            while (car1mileage <= 1000 || car2mileage <= 1000)
            {
                car1mileage += car1speed;
                car2mileage += car2speed;

                if (car1mileage == 1000 && car2mileage < 1000)
                {
                    Console.WriteLine($"Du vant med {car1name}!");
                }
                else if (car1mileage < 1000 && car2mileage == 1000)
                {
                    Console.WriteLine($"{car2name} vant! Sorry, buhu...");
                }
                else if (car1mileage == 1000 && car2mileage == 1000)
                {
                    Console.WriteLine("It's a tie");
                }
            }
        }
        public void BetterCarRace(Vehicle vehicle)
        {
            Random random = new Random();
            var driverIndex = random.Next(0, vehicle.cars.Count);
            var opponentIndex = random.Next(0, vehicle.cars.Count);

            Console.WriteLine("Velkommen til RaceWars!");

            Console.WriteLine($"Du kjører {vehicle.cars[driverIndex].CarName} mot {vehicle.cars[opponentIndex].CarName}!");
            Console.WriteLine("KJØØØØØØR!");
            Console.WriteLine();

            while (vehicle.cars[driverIndex].MileAge < 1000 || vehicle.cars[opponentIndex].MileAge < 1000)
            {
                vehicle.cars[driverIndex].MileAge += vehicle.cars[driverIndex].Speed;
                vehicle.cars[opponentIndex].MileAge += vehicle.cars[opponentIndex].Speed;
                
                switch (vehicle.cars[driverIndex].MileAge)
                {
                    case 1000 when vehicle.cars[opponentIndex].MileAge < 1000:
                        Console.WriteLine($"Du vant med {vehicle.cars[driverIndex].CarName}!");
                        break;
                    case < 1000 when vehicle.cars[opponentIndex].MileAge == 1000:
                        Console.WriteLine($"{vehicle.cars[opponentIndex].CarName} vant! Sorry, buhu...");
                        break;
                    case 1000 when vehicle.cars[opponentIndex].MileAge == 1000:
                        Console.WriteLine("It's a tie");
                        break;
                }
            }
        }
    }
}
