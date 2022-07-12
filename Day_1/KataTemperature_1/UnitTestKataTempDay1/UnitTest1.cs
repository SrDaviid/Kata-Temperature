using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataTemperature_1;

namespace UnitTestKataTempDay1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CelsiusToFarenheit()
        {
            ClassTemp_1 classTemp = new ClassTemp_1(10.0, TemperatureScale.Celsius);
            double result = classTemp.ToFarenheit();
            Assert.AreEqual(50.0, result);
        }

        [TestMethod]
        public void FarenheitToCelsius()
        {
            ClassTemp_1 classTemp = new ClassTemp_1(88, TemperatureScale.Farenheit);
            double result = classTemp.ToCelsius();
            Assert.AreEqual(31.11111111111111, result);
        }

        [TestMethod]
        public void KelvinToFarenheit()
        {
            ClassTemp_1 classTemp = new ClassTemp_1(15.5, TemperatureScale.Kelvin);
            double result = classTemp.ToFarenheit();
            Assert.AreEqual(-431.77, result);
        }

        [TestMethod]
        public void KelvinToCelsius()
        {
            ClassTemp_1 classTemp = new ClassTemp_1(15.5, TemperatureScale.Kelvin);
            double result = classTemp.ToCelsius();
            Assert.AreEqual( -257.66 ,result);
        }
    }
}
