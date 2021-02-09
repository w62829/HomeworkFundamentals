using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.firstname = "John";
            e.lastname = "Smith";
            Employee e2 = new Employee();
            e2.firstname = "Anna";
            e2.lastname = "Smith";
            Employee[] arr = new[] { e, e2 };

            foreach (var employee in arr)
            {
                Console.WriteLine($"{employee.firstname} {employee.lastname}");
            }
        }

        public struct Employee
        {
            public string firstname;
            public string lastname;

        }
    }
}
