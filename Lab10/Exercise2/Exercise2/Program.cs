using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankA a = new BankA();
            Console.WriteLine(a.GetBalance());
            BankB b = new BankB();
            Console.WriteLine(b.GetBalance());
            BankC c = new BankC();
            Console.WriteLine(c.GetBalance());
        }
        abstract class Bank
        {
            public int Balance { get; set; }
            public int GetBalance()
            {
                return Balance;
            }
        }
        public class BankA : Bank
        {
            public BankA()
            {
                Balance = 100;
            }
        }

       public class BankB : Bank
        {
            public BankB()
            {
                Balance = 200;
            }
        }

       public class BankC : Bank
        {
            public BankC()
            {
                Balance = 300;
            }
        }
    }
}
