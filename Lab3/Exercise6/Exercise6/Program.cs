using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Convert.ToInt32(Console.ReadLine());
            if (m> 0 && m <= 12)
            {
                Console.WriteLine(DateTime.DaysInMonth(DateTime.Now.Year, m));
            }
        }
    }
}
