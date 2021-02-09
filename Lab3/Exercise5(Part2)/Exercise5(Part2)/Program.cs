using System;

namespace Exercise5_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Prime factors = 1");
            for (var i = 0; n % 2 == 0; n /= 2)
            {
                Console.Write($" * {2}");
            }

            for (var i = 3; i <= n;)
            {
                if (n % i == 0)
                {
                    Console.Write($" * {i}");
                    n /= i;
                }
                else
                {
                    i += 2;
                }
            }
        }
    }
}
