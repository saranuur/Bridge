using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
       
        public Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        public abstract double Price();
        public abstract string VehicleType();
    }
}
