using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is 0");
            }
        }
    }
}
