using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any character");
            var ch = Convert.ToChar(Console.ReadLine());

          
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is an Alphabet. ");
            }

        }
    }
}
