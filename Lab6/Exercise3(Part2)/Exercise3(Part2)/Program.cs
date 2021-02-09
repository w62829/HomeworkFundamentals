using System;

namespace Exercise3_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoTimes t = new TwoTimes();
            Console.WriteLine(t);

        }
        public class TwoTimes
        {
            public TwoTimes()
            {
                var date1 = new DateTime(2021, 1, 1);
                var date2 = new DateTime(2020, 1, 1);

                Console.WriteLine(new DateTime(date2.Ticks + date1.Ticks));
            }
        }
    }
}
