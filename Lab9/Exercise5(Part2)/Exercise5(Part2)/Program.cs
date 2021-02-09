using System;

namespace Exercise5_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
             OddSum o = new OddSum(9);
             Console.WriteLine(o);
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
        public class OddSum : SecondBase
        {
            public OddSum(int n)
            {
                DisplaySecond();
                var sum = 0;
                Console.WriteLine(n);
                for (int i = 1; i < n; i += 2)
                {
                    sum += i;
                }

                Console.WriteLine($"Sum = {sum}");
                 
            }
        }
    }
}
