using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
             DvDPlayer d = new DvDPlayer();
             d.Disc = "Disc C";
             Console.WriteLine(d);
        }
        class DvDPlayer
        {
            private string _disc;
            public string Disc
            {
                get
                {
                    return $"The current disc is {_disc}";
                }
                set
                {
                    _disc = value;
                    Console.WriteLine($"The disc is now has value {value}");
                }
            }

        }

    }
}
