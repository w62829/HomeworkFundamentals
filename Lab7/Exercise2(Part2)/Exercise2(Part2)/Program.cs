using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse r = new Reverse(546);
            Console.WriteLine(r);
        }

        public class Reverse
        {
            public Reverse(int n)
            {
                int r = 0;
                while (n != 0)
                {
                    var rem = n % 10;
                    r = r * 10 + rem;
                    n /= 10;
                }

                Console.WriteLine(r);
            }
        }
    }
}
