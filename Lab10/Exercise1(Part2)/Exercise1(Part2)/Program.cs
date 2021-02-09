using System;

namespace Exercise1_Part2_
{
    class Program
    {
        static void Main(string[] args)
        {
             PoliceCar p = new PoliceCar();
             p.Emergency();
             p.LandVehicle();
        }
        interface IIsEmergency
        {
            public void Emergency();
        }

        interface IIsLandVehicle : IIsEmergency
        {
            public void LandVehicle();
        }
        public class PoliceCar : IIsLandVehicle
        {
            public void Emergency()
            {
                Console.WriteLine("Emergency status");
            }

            public void LandVehicle()
            {
                Console.WriteLine("Vehicle status");
            }
        }
    }
}
