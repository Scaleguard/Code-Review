using System;

namespace Speedometer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks for distance and time as input and displays the speed in kilometers per hour*/
            Console.WriteLine("Enter covered distance in km: ");
            double speed = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter time spent in hours: ");
            double time = Int32.Parse(Console.ReadLine());

            double kph = speed / time;

            Console.WriteLine($"Your kph speed is {kph}!");
        }
    }
}
