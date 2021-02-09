using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers for average");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Average = {(a + b + c + d) / 4}");
            
        }
    }
}
