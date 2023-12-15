using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GA_CodeAlong
{
    public class Vehicle
    {
        public string CarName { get; set; }
        public int MileAge { get; set; }
        public int Speed { get; set; }

        public List<Vehicle> cars {  get; set; }  
        


        public Vehicle(string carName, int mileAge, int speed)
        {
            MileAge = mileAge;
            Speed = speed;
            CarName = carName;

            cars = new List<Vehicle>();
        }

        public void AddCarsToList()
        {
            cars.Add(new Vehicle(carName: "BilBølla", mileAge: 0, speed: 10));
            cars.Add(new Vehicle (carName: "PuttPutt", mileAge: 0, speed: 15));
            cars.Add(new Vehicle (carName: "CrotchRocket", mileAge: 0, speed: 20));
        }

        public T GetValueAtIndex<T>(int index, Func<Vehicle, T> propertySelector)
        {
            if (index >= 0 && index < cars.Count)
            {
                return propertySelector(cars[index]);
            }
            else
            {
                return default(T);
            }
        }

        public string GetCarNameAtIndex(int index) => GetValueAtIndex(index, car => car.CarName).ToString();
        public int GetSpeedAtIndex(int index) => GetValueAtIndex(index, car => car.Speed);
        public int GetMileageAtIndex(int index) => GetValueAtIndex(index, car => car.MileAge);
    }
}
