using System.ComponentModel;

namespace Bridge
{
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }


        public Car( string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;

        }

        /// <summary>
        /// Her returnere jeg prisen af bilen
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Her returnere jeg typen af bilen
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car"; 
        }
    }
}
