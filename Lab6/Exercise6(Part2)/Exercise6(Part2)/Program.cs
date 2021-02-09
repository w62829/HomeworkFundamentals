using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
      
        }

        public class Election
        {
            public Dictionary<string, int> Candidates { get; set; }

            public void GetWinner()
            {
                Console.WriteLine(Candidates.Aggregate((x, y) => x.Value > y.Value ? x : y).Key);
            }
        }
    }
}
