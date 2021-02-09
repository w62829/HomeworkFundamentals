using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
             
        }

        public class Triangle
        {
            private int _a;
            private int _b;

            public Triangle(int a, int b)
            {
                _a = a;
                _b = b;
            }

            public int Area()
            {
                return (int) (_a * _b* 0.5);
            }
        }
    }
}
