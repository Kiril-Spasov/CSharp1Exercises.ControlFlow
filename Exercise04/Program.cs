using System;

namespace Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pls enter speed of the car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demeritPoints);
                }

            }

        }
    }
}
