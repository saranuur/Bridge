using System.ComponentModel;

namespace Bridge
{
    public class Car : Vehicle
    {
        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            if (LicensePlate.Length > 7)
            {
                throw new Exception("Licenseplate is too long");
            }

        }

        /// <summary>
        /// Her returnere jeg prisen af bilen
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Her returnere jeg typen af bilen
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car"; 
        }
    }
}
