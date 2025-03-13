using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC : Vehicle
    {
        public bool Brobizz { get; set; }
        public MC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            if (LicensePlate.Length > 7)
            {
                throw new Exception("Licenseplate is too long");
            }

        }
         /// <summary>
         /// Her returneres prisen af MC'en
         /// </summary>
         /// <returns></returns>
        public override double Price()
        {
            double price  = 120;

            if (Brobizz)
            {
                price *= 0.9;

            }

            return price;
        }

        /// <summary>
        /// Her returneres "MC"
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
