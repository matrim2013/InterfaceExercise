using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
        public interface IVehicle
        {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        }
}
