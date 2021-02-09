using System;

namespace Exercise3_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = Convert.ToInt32(Console.Read());
            Console.WriteLine(Prime(inputNumber));
        }
        public static bool Prime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            var t = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= t; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
