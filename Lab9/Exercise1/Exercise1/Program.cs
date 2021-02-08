using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
             Cube c = new Cube(3);
             Console.WriteLine(c);
        }
        public class Base
        {
            public void Display()
            {
                Console.WriteLine("Base class");
            }
        }

        public class Cube:Base
        {
            private int _n;

            public Cube(int n)
            {
                _n = n;
                
                Display();
                Console.WriteLine(n * n * n);

            }
        }
    }
}
