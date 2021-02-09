using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"{a}, {b}");
        }
    }
}
