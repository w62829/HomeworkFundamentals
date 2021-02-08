using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = Convert.ToDouble(Console.ReadLine());
            if (grade < 3.0)
            {
                Console.WriteLine("You have to retake this course");
            }
            if (grade >= 3.0 && grade < 4.0)
            {
                Console.WriteLine("You passed this course");
            }
            if (grade >= 4.0 && grade < 5.0)
            {
                Console.WriteLine("You finished this course with fairly good grade");
            }
            if (grade == 5.0)
            {
                Console.WriteLine("You scored maximum possible grade! Good job!");
            }
            



        }
    }
}
