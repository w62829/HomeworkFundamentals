using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a >= -10 && a <= 10 || b >= -10 && b <= 10)
            {
                Console.WriteLine(true);
            }
        }
    }
}
