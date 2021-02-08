using System;

namespace Exercise4_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Seconds s = new Seconds(120);
            Console.Write(s);
        }
        public class Seconds
        {

            public Seconds(int inputSeconds)
            {

                var hours = inputSeconds / 3600;
                inputSeconds -= hours * 3600;
                var minutes = inputSeconds / 60;
                inputSeconds -= minutes * 60;
                var seconds = inputSeconds;

                Console.WriteLine($"{hours}:{minutes}:{seconds}");

            }
        }
    }
}
