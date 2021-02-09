using System;

namespace Exercise4_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            var sum = 0;
            var m = 0;
            Console.WriteLine("Please enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
