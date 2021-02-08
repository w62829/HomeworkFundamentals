using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your operator");
            var sign = Console.ReadLine();
            Console.WriteLine("Enter numbers");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            switch (sign)
            {
                case "+":
                    Console.WriteLine(a + b);
                    return;

                case "-":
                    Console.WriteLine(a - b);
                    return;

                case "*":
                    Console.WriteLine(a * b);
                    return;

                case "/":
                    Console.WriteLine(a / b);
                    return;

                default:
                    Console.WriteLine("Incorrect inputs");
                    return;
            }
        }
    }
}
