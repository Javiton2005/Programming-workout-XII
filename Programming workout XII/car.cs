using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_workout_XII
{
    public class car : vehicle
    {
        int numberOfSeats;
        public car(string registrationNumber, string brand, string model, int numberOfSeats) : base(registrationNumber, brand, model)
        {
            this.numberOfSeats = numberOfSeats;
        }
        public override double GetRentalCost()
        {

            return 100+85*this.numberOfSeats;
        }
        public override string GetvehicleDetails()
        {
            return $"Brand {this.brand}\nModel {this.model}\nRegistration Number {this.registrationNumber}\n\n Number of seats {this.numberOfSeats}";
        }
    }
}
