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
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            var mc = new MC("R4DSY", DateTime.Now);

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(120, price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            var mc = new MC("R4DSY", DateTime.Now);

            //Act
            string vehicleType = mc.VehicleType();

            //Assert
            Assert.AreEqual("MC", vehicleType);
        }
    }
}