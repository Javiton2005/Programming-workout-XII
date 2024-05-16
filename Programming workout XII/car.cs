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
            return 0.0;
        }
        public override double GetvehicleDetails()
        {
            return 0.0;
        }
    }
}
