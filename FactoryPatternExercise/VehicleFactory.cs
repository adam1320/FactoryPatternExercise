using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle BuildNewVehicle()
        {
            Console.WriteLine($"How many wheels do you like on your vehicle?");
                int NumberOfWheels = int.Parse(Console.ReadLine());
            if (NumberOfWheels == 4)
            {
                
                Console.WriteLine("Your new car is ready");
                return new Car();

            }
            else if (NumberOfWheels == 2)
            {
                Console.WriteLine("Your new Motorcycle is ready");
                return new Motorcycle();
            }
            else
            {
                Console.WriteLine($"We dont have any {NumberOfWheels}-wheeled models, Im sorry.");
                return null;
            }
              
            

        }
    }
}
