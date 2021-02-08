using System;

namespace Exercise4_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
             
            var n = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
                Console.WriteLine("Input is perfect");
            else
                Console.WriteLine("Input is not perfect");
        }
    }
}
