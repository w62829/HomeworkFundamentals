using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] array2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] array3 = new int[3, 3];
            int rA = array1.GetLength(0);
            int cA = array1.GetLength(1);
            int rB = array2.GetLength(0);
            int cB = array2.GetLength(1);
            int temp = 0;
            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    temp = 0;
                    for (int k = 0; k < cA; k++)
                    {
                        temp += array1[i, k] * array2[k, j];
                    }
                    array3[i, j] = temp;
                }
            }

            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3.Length; j++)
                {
                    Console.Write($"{array3[i, j]}");
                }
            }
        }
    }
}
