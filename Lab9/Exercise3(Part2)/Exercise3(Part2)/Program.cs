using System;

namespace Exercise3_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal d = new Decimal(5);
            Console.WriteLine(d);
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
        public class Decimal : SecondBase
        {
            private int _decimal;
            
            public Decimal(int d)
            {
                _decimal = d;
                DisplaySecond();
                Console.WriteLine(Convert.ToString(_decimal, 2));
                
            }
        }
    }
}
