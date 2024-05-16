using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_workout_XII
{
    public abstract class vehicle
    {
        protected string registrationNumber;
        protected string brand;
        protected string model;

        public vehicle(string registrationNumber, string brand, string model)
        {
            this.registrationNumber = registrationNumber;
            this.brand = brand;
            this.model = model;
        }

        public abstract double GetRentalCost();
        public abstract string GetvehicleDetails();

    }
}
