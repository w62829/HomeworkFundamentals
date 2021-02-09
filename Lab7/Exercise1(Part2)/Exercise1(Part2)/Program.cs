using System;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Diamond d = new Diamond(6);
            Console.Write(d);
        }

        public class Diamond
        {
            public Diamond(int r)
            {
             
                for (int i = 0; i <= r; i++)
                {
                    for (int j = 1; j <= r - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }

                for (int i = r - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= r - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }

        }
    }
}
