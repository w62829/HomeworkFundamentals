using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Converter c = new Converter(5);
            Console.Write(c);
        }
        public class Converter
        {
            private int _decimal;
            public Converter(int _decimal)
            {
                Console.WriteLine(Convert.ToString(_decimal, 2));
            }
        }
    }
}
