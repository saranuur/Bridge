using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Tests
{
    [TestClass()]
    public class CarTests
    {
        
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            var car = new Car("Range", DateTime.Now);

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(230, price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            var car = new Car("Range", DateTime.Now);

            //Act
            string vehicleType = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", vehicleType);

        }
    }
}