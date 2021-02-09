using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {  
            int d = 0;
            
            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                d = d + (array1[0, i] * (array1[1, (i + 1) % 3] * array1[2, (i + 2) % 3] -
                                         array1[1, (i + 2) % 3] * array1[2, (i + 1) % 3]));
            }

            Console.WriteLine(d);
        }
    }
}
