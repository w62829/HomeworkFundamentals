using System;

namespace Exercise5_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting hexidecimal number to decimal number");
            string hexval = Console.ReadLine();
            Console.WriteLine("Hexidecimal number = " + hexval);
            var decvalue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.Write("Decimal number = ");
            Console.WriteLine(decvalue);
        }
    }
}
