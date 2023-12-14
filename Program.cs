﻿namespace GA_CodeAlong
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
            Bil BilInstance = new Bil("", Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue);

            BilInstance.MileAge = 0;
            BilInstance.Speed = 10;

            while (BilInstance.MileAge <= 1000)
            {
                if (BilInstance.MileAge == 0 || BilInstance.MileAge < 500)
                {
                    BilInstance.Speed += 10;
                    Console.WriteLine("Speed opp");
                } 
                else if (BilInstance.MileAge <= 1000 && BilInstance.Speed >= 10)
                {
                    BilInstance.Speed -= 10;
                    Console.WriteLine("Speed ned");
                }
                else
                {
                    BilInstance.Speed = 10;
                }
                BilInstance.MileAge += 10;
            }

            Console.WriteLine("Bilen er parkert og du er fremme.");
        }
    }
}