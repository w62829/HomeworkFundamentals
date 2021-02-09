using System;

namespace Exercise4_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
           Floyd f = new Floyd(8);
           Console.WriteLine(f);
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
        public class Floyd : SecondBase
        {
            public Floyd(int n)
            {
                DisplaySecond();
                var a = 1;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{a} ");
                        a++;
                    }

                    Console.WriteLine();
                }

                
            }
        }
    }
}
