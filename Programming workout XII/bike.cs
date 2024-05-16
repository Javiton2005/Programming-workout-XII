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
            if (hasHelmetIncluded)
            {
                return 200 + 145;
            }else
            {
                return 200;
            }
        }
        public override string GetvehicleDetails()
        {
            return $"Brand: {this.brand}\nModel: {this.model}\nRegistration Number: {this.registrationNumber}\n\n Helmet Included: {this.hasHelmetIncluded}" ;
        }
    }
}
