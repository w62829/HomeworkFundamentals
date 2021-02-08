using System;

namespace Exercise7_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine($"Even = {true}");
            }

            if (a % 2 != 0 && b % 2 != 0)
            {
                Console.WriteLine($"Odd = {true}");
            }
        }
    }
}
