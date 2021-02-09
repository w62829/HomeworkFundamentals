using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
          Floyd f = new Floyd(9);
          Console.WriteLine(f);
        }

        public class Floyd
        {
            public Floyd(int n)
            {
                 
                var t = 1;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{t} ");
                        t++;
                    }

                    Console.WriteLine();
                }
            }
        }

    }
}
