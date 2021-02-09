using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
