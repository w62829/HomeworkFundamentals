using System;

namespace Exercise7_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
             
        }
        class Account
        {
            private string _name;
            private double _amount;

            public Account(string name, double amount)
            {
                _name = name;
                _amount = amount;
            }

            public void Deposit(double amount)
            {
                _amount += amount;
            }

            public void WithDraw(double amount)
            {
                if (_amount >= amount)
                {
                    _amount -= amount;
                }
                else
                {
                    throw new Exception("You do not have enough money");
                }
            }
        }
    }
}
