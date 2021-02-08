using System;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
             
        }
        private delegate int Rand();

        public static int GetRand()
        {
            var random = new Random();
            return random.Next();
        }

        public static void Delegate()
        {
            Rand rnd;
            rnd = GetRand;
            Console.WriteLine(rnd());

        }
    }
}
