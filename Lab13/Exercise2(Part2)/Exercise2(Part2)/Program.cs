using System;
using System.Collections.Generic;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Attendace();
        }
        public delegate void Message(string message);
        public static event Message Notify;
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void Attendace()
        {
            Notify += DisplayMessage;
            var str = Console.ReadLine();
             
             
                if (str == "Steven" || str == "Mathew")
                {
                    Notify?.Invoke("Banned");
                }
                else
                {
                    Notify?.Invoke($"Welcome {str}!");

                }
           
        }
    }
}
