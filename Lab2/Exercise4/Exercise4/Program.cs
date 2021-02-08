using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var result = a >= 20 && a <= 100;
            Console.WriteLine(result);
        }
    }
}
