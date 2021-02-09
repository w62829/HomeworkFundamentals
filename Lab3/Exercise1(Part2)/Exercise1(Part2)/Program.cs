using System;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            string num = "0123456789";
        

            if (num.Contains(n))
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Not allowed");
            }
        }
    }
}
