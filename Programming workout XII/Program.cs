using Programming_workout_XII;
using System;
namespace code
{
    public class Program
    {
        public static void Main ()
        {
            RentalService rental = new RentalService();

            car car1 = new car("1234","Mercedes","G class", 5);
            car car2 = new car("1244JGV", "Audi", "GLA", 2);
            bike bike1 = new bike("0954", "Orbea", "H30", false);
            bike bike2 = new bike("57435", "Harley", "Ultimate", true);


            rental.addVehicle(car1);
            rental.addVehicle(car2);
            rental.addVehicle(bike1);
            rental.addVehicle(bike2);

            rental.calculateTotalrentalCost();

            rental.ProntVehicleDetails();

        }   
    }
}