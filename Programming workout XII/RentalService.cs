using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_workout_XII
{
    internal class RentalService
    {
        List<vehicle> vehicles;
        public RentalService() 
        {
            vehicles = new List<vehicle>();
        }
        public void addVehicle(vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        public void calculateTotalrentalCost() 
        {
            foreach (vehicle vehicle in vehicles) 
            {
                Console.WriteLine(vehicle.GetvehicleDetails());
            }

        }

        public void ProntVehicleDetails()
        {
            foreach (vehicle vehicle in vehicles)
            {
                Console.WriteLine();
                Console.WriteLine(vehicle.GetvehicleDetails());
            }
        }
    }
}
