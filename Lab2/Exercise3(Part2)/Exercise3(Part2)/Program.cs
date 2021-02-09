using System;

namespace Exercise3_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var result = a < 100;
            var result2 = b > 200;
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
