using System;

namespace Exercise4_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give temperatures in Celsius");
            var tempInput = Console.ReadLine();
            var temp = Convert.ToDouble(tempInput);
            var fahrenheit = 9 / 5 * temp + 32;
            var kelvin = temp + 273.15;
            Console.WriteLine($"Fahrenheit is {fahrenheit} F");
            Console.WriteLine($"Kelvin is {kelvin} K");
        }
    }
}
