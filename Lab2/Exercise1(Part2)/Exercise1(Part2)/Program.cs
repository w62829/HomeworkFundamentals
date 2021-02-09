using System;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0 || a % 7 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
