using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers for calculations");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }
}
