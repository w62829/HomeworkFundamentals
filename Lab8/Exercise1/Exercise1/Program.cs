using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            SumAP s = new SumAP(4,2,6);
            Console.WriteLine(s);
        }

        public  class SumAP
        {
            public SumAP(int first, int diff, int n)
            {

                Console.WriteLine($"Sum is {(2 * first + diff * (n - 1)) * n / 2}");
            }

        }

    }
}
