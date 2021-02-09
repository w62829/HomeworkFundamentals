using System;

namespace Exercise2_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
             Warrior w = new Warrior();
             w.Run();
        }
        interface IWarrior
        {
            public void Attack();
            public void Run();
        }

        interface IMonster
        {
            public void Bite();
        }

        interface IObject
        {
            public void Status();
        }
        public class Warrior : IWarrior
        {
            public void Attack()
            {
                Console.WriteLine("Attack");
            }

            public void Run()
            {
                Console.WriteLine("Run");
            }
        }

        public class Monster : IMonster
        {
            public void Bite()
            {
                Console.WriteLine("Bite");
            }
        }

        public class Object : IObject
        {
            public void Status()
            {
                Console.WriteLine("Status");
            }
        }

    }
}
