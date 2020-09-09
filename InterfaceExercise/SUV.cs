using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public string Name { get; set; }
        public string Motto { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is in drive");
        }

        public void Park()
        {
            Console.WriteLine($"{ GetType().Name} is in park");
        }

        public void Reverse()
        {
            Console.WriteLine($"{ GetType().Name} is in reverse");
        }
        public bool FourWheelDrive { get; set; } = true;
        public string CargoHoldSize { get; set; }
    }
}
