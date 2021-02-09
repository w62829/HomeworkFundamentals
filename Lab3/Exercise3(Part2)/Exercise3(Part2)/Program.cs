using System;

namespace Exercise3_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
             
            var b = Console.ReadLine();
            var h = Convert.ToInt32(b, 2).ToString("X");
            
            Console.WriteLine(h);
        }
    }
}
