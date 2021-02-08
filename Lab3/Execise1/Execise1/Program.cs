using System;

namespace Execise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integer numbers");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            var i = Math.Max(a, b);
            var max = Math.Max(c, i);

            var k = Math.Min(a, b);
            var min = Math.Min(c, k);
            Console.WriteLine($"Maximum = {max}");
            Console.WriteLine($"Minimum = {min}");
        }
    }
}
