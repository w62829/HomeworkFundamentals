using System;

namespace Exercise4_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter radius of a circle");
            var radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Perimeter is {radius * 2 * 3.14}");
            Console.WriteLine($"Area is {(radius * radius) * 3.14}");
        }
    }
}
