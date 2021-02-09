using System;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid p = new Pyramid();
            Console.WriteLine(p);
        }
        public class Base
        {
            public void Display()
            {
                Console.WriteLine("Base class");
            }
        }
        public class SecondBase : Base
        {
            public void DisplaySecond()
            {
                Display();
                Console.WriteLine("Second base class");
            }
        }
        public class Pyramid : SecondBase
        {
            public Pyramid()
            {
                DisplaySecond();
                var h = 10;

                for (int i = h - 1; i >= 0; --i)
                {
                    for (int j = 0; j < i; ++j)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < (h - i) * 2 - 1; ++j)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

                  
            }
        }

    }
}
