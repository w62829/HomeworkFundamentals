using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
          ParentFirst f = new ParentFirst("123");
          Console.WriteLine(f.First());
        }
       public abstract class Parent
        {
            public string message { get; set; }
            public void Message()
            {
                Console.WriteLine(message);
            }
        }
        public class ParentFirst : Parent
        {
            public ParentFirst(string m)
            {
                message = m;
            }
            public string First()
            {
                message = "This is first class";
                return message;
            }
        }
        public class ParentSecond : Parent
        {
            public ParentSecond(string m)
            {
                message = m;
            }
            public string Second()
            {
                message = "This is second class";
                return message;
            }
        }
    }
}
