using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            var n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine("Enter the number for array");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
