using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECC.Core.Features;

namespace ECC.Core.Test
{
    [TestClass]
    public class ResistorTest
    {
        private ResistorCalculator _resistor;

        [TestInitialize]
        public void Initialize()
        {
            _resistor = new ResistorCalculator();
        }

        [TestMethod]
        public void Calculates_The_Ohm_Value_Based_On_Bands()
        {

            var expectedResult = _resistor.CalculateOhmValue(Enums.ColorEnum.Yellow.ToString(), Enums.ColorEnum.Violet.ToString(), Enums.ColorEnum.Red.ToString());

            Assert.AreEqual(4700, expectedResult);

        }

        [TestMethod]
        public void Calculates_Real_Value_Based_On_Bands()
        {
            var expectedResult = _resistor.RealCalculateOhmValue(Enums.ColorEnum.Yellow.ToString(), Enums.ColorEnum.Violet.ToString(), Enums.ColorEnum.Red.ToString(), Enums.ColorEnum.Gold.ToString());

            Assert.AreEqual(Tuple.Create(4465D, 4935D), expectedResult);
        }

        [TestMethod]
        public void Calculates_Real_Value_Without_Tolerance_Value()
        {
            var expectedResult = _resistor.RealCalculateOhmValue(Enums.ColorEnum.Yellow.ToString(), Enums.ColorEnum.Violet.ToString(), Enums.ColorEnum.Red.ToString());

            Assert.AreEqual(Tuple.Create(3760D, 5640D), expectedResult);

        }

        [TestCleanup]
        public void CleanUp()
        {
        }

    }
}
