using YECG.Temperatura;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YECG.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    { 
        private TemperatureConverter _converter;

        [TestInitialize]
        public void Setup()
        {
            _converter = new TemperatureConverter();
        }

        // Prueba para Celsius a Fahrenheit
        [TestMethod]
        public void CelsiusToFahrenheit_ShouldReturnCorrectValue()
        {
            // Arrange
            double celsius = 0; // punto de congelación
            double expectedFahrenheit = 32;

            // Act
            double result = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expectedFahrenheit, result);
        }

        // Prueba para Fahrenheit a Celsius
        [TestMethod]
        public void FahrenheitToCelsius_ShouldReturnCorrectValue()
        {
            // Arrange
            double fahrenheit = 32; // punto de congelación
            double expectedCelsius = 0;

            // Act
            double result = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expectedCelsius, result);
        }
    }
}
