using System;

namespace Exercise5_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class TimeToSeconds
        {
            private int _hours;
            private int _minutes;
            private int _seconds;

            public TimeToSeconds(int hours, int minutes, int seconds)
            {
                _hours = hours;
                _minutes = minutes;
                _seconds = seconds;
            }

            public int Time()
            {
                return _hours * 3600 + _minutes * 60 + _seconds;
            }
        }
    }
}
