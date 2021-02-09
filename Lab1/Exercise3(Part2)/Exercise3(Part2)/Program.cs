using System;

namespace Exercise3_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please three numbers");
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());
            var z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x + y) * z);
            Console.WriteLine(x * y);

        }
    }
}
