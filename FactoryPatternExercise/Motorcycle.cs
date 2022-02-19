using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public int NumberOfWheels { get; set; } = 2;
        public int VehicleWeight { get; set; } = 600;

        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle!");
        }
    }
}
