using System.Net.WebSockets;

namespace GA_CodeAlong
{
    //Bil som skal kjøre 1000m
    //start-hastighet 10m/s (en iterasjon i en løkke er 1s)
    //øke farten med 10m/s frem til den har kjørt 500m
    //senke farten med 10m/s etter 500m til minimum 10m/s
    //1000m = print at bilen er parkert og fremme

    internal class Program
    {
        static void Main()
        {
            bool RunProgram = true;
            Vehicle vehicle = new Vehicle("", Int32.MaxValue, Int32.MaxValue);
            Drive drive = new Drive();
            vehicle.AddCarsToList();

            while (RunProgram)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("Hva vil du gjøre?");
                Console.WriteLine("1. Kjøre bil alene");
                Console.WriteLine("2. Bilrace");
                Console.WriteLine("3. Exit");

                var userChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (userChoice)
                {
                    case '1':
                        drive.RunCar(vehicle);
                        Console.WriteLine();
                        break;
                    case '2':
                        drive.BetterCarRace(vehicle);
                        Console.WriteLine();
                        break;
                    case '3':
                        RunProgram = false;
                        Console.WriteLine("Bye Bye...");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Velg 1, 2 eller 3");
                        break;
                }
            }
        }

    }
}
