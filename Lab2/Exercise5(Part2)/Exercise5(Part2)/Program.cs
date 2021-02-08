using System;

namespace Exercise5_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter parameters for distance and time");
            var distance = Convert.ToInt32(Console.ReadLine());
            var time = Convert.ToInt32(Console.ReadLine());
            var speed = distance / time;
            Console.WriteLine($"Speed is {speed} km/h");
            Console.WriteLine($"Speed is in miles {speed * 1.609} m/h");

        }
    }
}
