using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "John";
            Console.WriteLine(p.Name);
        }


        class Person
        {
            private string name;

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }
        }
    }
}
