using Product.Api.Model; // Reference the namespace of your model
// using Xunit;
// using Product.Api;

namespace Product.Api.Tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void TemperatureF_CalculatedCorrectly_FromTemperatureC()
        {
            // Arrange: Create an instance of WeatherForecast
            var weatherForecast = new WeatherForecast
            {
                TemperatureC = 25
            };

            // Act: Calculate the TemperatureF
            var temperatureF = weatherForecast.TemperatureF;

            // Assert: Check if the result is correct (32 + (25 / 0.5556) ≈ 77)
            Assert.Equal(76, temperatureF);
        }

        [Fact]
        public void WeatherForecast_SummaryCanBeNull()
        {
            // Arrange: Create an instance of WeatherForecast with no summary
            var weatherForecast = new WeatherForecast
            {
                Date = new DateOnly(2025, 6, 24),
                TemperatureC = 20,
                Summary = null
            };

            // Act: Check if the summary is null
            var summary = weatherForecast.Summary;

            // Assert: Ensure Summary is null
            Assert.Null(summary);
        }

        [Theory]
        [InlineData(0, 32)] // Freezing point in Celsius
        [InlineData(100, 211)] // Boiling point in Celsius
        [InlineData(-10, 15)] // Negative temperature
        public void TemperatureF_CorrectlyConvertsToFahrenheit(int temperatureC, int expectedTemperatureF)
        {
            // Arrange: Create an instance of WeatherForecast with the provided temperature
            var weatherForecast = new WeatherForecast
            {
                TemperatureC = temperatureC
            };

            // Act: Calculate the TemperatureF
            var temperatureF = weatherForecast.TemperatureF;

            // Assert: Check if the temperature conversion is correct
            Assert.Equal(expectedTemperatureF, temperatureF);
        }
        [Theory]
        [InlineData(35, "Hot")]
        [InlineData(5, "Cold")]
        [InlineData(20, "Moderate")]
        public void GetTemperatureCategory_ReturnsCorrectCategory(int tempC, string expectedCategory)
        {
            // Arrange
            var weatherForecast = new WeatherForecast
            {
                TemperatureC = tempC
            };

            // Act
            var category = weatherForecast.GetTemperatureCategory();

            // Assert
            Assert.Equal(expectedCategory, category);
        }

    }
}
