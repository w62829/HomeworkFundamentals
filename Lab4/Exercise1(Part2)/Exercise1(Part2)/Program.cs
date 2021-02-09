using System;
using System.Linq;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Convert.ToString(Console.ReadLine());
            Console.WriteLine(s.Count(Char.IsWhiteSpace));
        }
    }
}
