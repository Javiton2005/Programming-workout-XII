using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_workout_XII
{
    public class bike : vehicle
    {
        bool hasHelmetIncluded;
        public bike(string registrationNumber, string brand, string model, bool hasHelmetIncluded) : base(registrationNumber, brand, model)
        {
            this.hasHelmetIncluded = hasHelmetIncluded;
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
