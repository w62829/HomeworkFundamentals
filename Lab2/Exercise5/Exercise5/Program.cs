using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing odd numbers between 1 to 99");
            var a = 1;
            while (a < 100)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine(a);
                }

                a++;
            }
        }
    }
}
