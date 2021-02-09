using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            SumAP s = new SumAP(3,2,4);
            Console.WriteLine(s);
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
       public class SumAP : SecondBase
        {
            public SumAP(int first, int diff, int n)
            {
                DisplaySecond();
                Console.WriteLine($"Sum is {(2 * first + diff * (n - 1)) * n / 2}");
            }
        }
    }
}
