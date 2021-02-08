using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
             ChildEngine c = new ChildEngine();
             c.Engine(23,45,78);
        }
    }
    public class BaseEngine
    {
        public virtual void Engine(double power, int rpm, int cylinder)
        {
            Console.WriteLine($"Power is {power}");
        }
    }

    public class ChildEngine : BaseEngine
    {
        public override void Engine(double power, int rpm, int cylinder)
        {
            Console.WriteLine($"Power is {power}");
            Console.WriteLine($"RPM is {rpm}");
            Console.WriteLine($"Cylinder number = {cylinder}");
        }
    }
}
