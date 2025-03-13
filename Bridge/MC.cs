using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class MC
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        public MC( string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = Date;

        }
         /// <summary>
         /// Her returneres prisen af MC'en
         /// </summary>
         /// <returns></returns>
        public double Price()
        {
            return 120;
        }

        /// <summary>
        /// Her returneres "MC"
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "MC";
        }

    }
}
