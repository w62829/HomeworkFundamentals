using System;

namespace Exercise5_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            var fact = 1; 
            
            Console.WriteLine("Please enter number");
            var n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.Write($"Factorial is {fact}");
        }
    }
}
