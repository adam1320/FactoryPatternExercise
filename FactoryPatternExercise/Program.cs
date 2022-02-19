using System;

namespace FactoryPatternExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle MyVehicle = VehicleFactory.BuildNewVehicle();
             
        }
    }
}
