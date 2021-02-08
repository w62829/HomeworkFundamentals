using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
        public class TwoDistances
        {
          private double _feet;
          private double _inches;

          public double Feet => _feet;
          public double Inches => _inches;

          public double Sum()
          {
               return Feet * 12.0 + Inches;
            }
        }

    }
}
