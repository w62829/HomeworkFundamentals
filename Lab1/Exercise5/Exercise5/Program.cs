using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers for multiplication");
            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());
            var c = Convert.ToInt16(Console.ReadLine());
            Console.Write("Result = ");
            Console.WriteLine(a*b*c);
        }
    }
}
