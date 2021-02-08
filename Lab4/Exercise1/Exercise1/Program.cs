using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new Double[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public static double mean(double[] m)
        {
            double sum = 0;
            for (int i = 0; i < m.Length; i++)
            {
                sum += m[i];
            }

            return sum / m.Length;
        }

        public static double median(double[] m)
        {
            Array.Sort(m);
            int middle = m.Length / 2;
            if (m.Length % 2 == 1)
            {
                return m[middle];
            }
            else
            {
                return (m[middle - 1] + m[middle + 1]) / 2.0;
            }
        }

        public static double mode(double[] m)
        {
            double maxValue = 0, maxCount = 0;
            for (int i = 0; i < m.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < m.Length; j++)
                {
                    if (m[j] == m[i])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = m[i];
                }
            }

            return maxValue;
        }

    }
}
