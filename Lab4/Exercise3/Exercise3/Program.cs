using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Define size of an array");
            var n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number for array");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var dict = new Dictionary<int, int>();

            foreach (int a in arr)
            {
                if (dict.ContainsKey(a))
                    dict[a] = dict[a] + 1;
                else
                    dict[a] = 1;
            }

            foreach (KeyValuePair<int, int> keyValue in dict)
            {

                if (keyValue.Value > 1)
                {
                    Console.WriteLine($"Duplicate of {keyValue.Key}, {keyValue.Value}");
                }

            }

        }
    }
}
