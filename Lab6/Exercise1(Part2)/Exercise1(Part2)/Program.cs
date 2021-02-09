using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
 
        }
       public class Student
        {
            public string Name { get; set; }
            public string StudentId { get; set; }
            public List<Int32> Marks { get; set; }
            public double Final => Marks.Average();
        }
    }
}
