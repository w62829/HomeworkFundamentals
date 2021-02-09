using System;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");

            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Adding = {a+b}");
            Console.WriteLine($"Subtracting = {a-b}");
            Console.WriteLine($"Multiplication = {a * b}");
            Console.WriteLine($"Dividing = {a/b}");

        }
    }
}
