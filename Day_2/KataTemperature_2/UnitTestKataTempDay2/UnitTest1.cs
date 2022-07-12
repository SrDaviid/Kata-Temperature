using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataTemperature_2;


namespace UnitTestKataTempDay2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CelsiusToFarenheit()
        {
            ClassTemperatures temp = new ClassTemperatures(16.8, Scale.Celsius);
            Assert.AreEqual(62.24, temp.ToFarenheit());
        }

        [TestMethod]
        public void FarenheitToCelsius()
        {
            ClassTemperatures temp = new ClassTemperatures(5, Scale.Farenheit);
            Assert.AreEqual(-15, temp.ToCelsius());
        }

        [TestMethod]
        public void CelsiusToKelvin()
        {
            ClassTemperatures temp = new ClassTemperatures(32, Scale.Kelvin);
            Assert.AreEqual(-241.15, temp.ToCelsius());
        }

        [TestMethod]
        public void FarenheitToKelvin()
        {
            ClassTemperatures temp = new ClassTemperatures(32, Scale.Farenheit);
            Assert.AreEqual(273.15, temp.ToKelvin());
        }

        [TestMethod]
        public void KelvinToCelsius()
        {
            ClassTemperatures temp = new ClassTemperatures(32, Scale.Kelvin);
            Assert.AreEqual(-241.15, temp.ToKelvin());
        }
        
        [TestMethod]
        public void KelvinToFarenheit()
        {
            ClassTemperatures temp = new ClassTemperatures(32, Scale.Kelvin);
            Assert.AreEqual(-402.07, temp.ToKelvin());
        }

        [TestMethod]
        public void KelvinToKelvin()
        {
            ClassTemperatures temp = new ClassTemperatures(12, Scale.Kelvin);
            Assert.AreEqual(12, temp.ToKelvin());
        }

        [TestMethod]
        public void CelsiusToCelsius()
        {
            ClassTemperatures temp = new ClassTemperatures(43, Scale.Kelvin);
            Assert.AreEqual(43, temp.ToKelvin());
        }

        [TestMethod]
        public void FarenheitToFarenheit()
        {
            ClassTemperatures temp = new ClassTemperatures(54, Scale.Kelvin);
            Assert.AreEqual(54, temp.ToKelvin());
        }


    }
}
