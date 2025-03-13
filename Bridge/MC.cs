using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC : Vehicle
    {
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
            return 120;
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
