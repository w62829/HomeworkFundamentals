using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
             Book b = new Book();
             Book b2 = new Book();

             b.nameBook = "C#";
             b2.nameBook = "C++";
             Console.WriteLine(b.nameBook);
        } 
        public struct Book
        {
            public string bookNumber;
            public string nameBook;
            public string autorName;
        }
    }
}
