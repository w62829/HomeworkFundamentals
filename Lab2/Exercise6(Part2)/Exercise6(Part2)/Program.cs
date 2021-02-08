using System;

namespace Exercise6_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of sphere");
            var radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Volume = { (4 / 3) * (radius * 3.14)}");
            Console.WriteLine($"Surface Area = {4 * radius * 3.14}");
        }
    }
}
