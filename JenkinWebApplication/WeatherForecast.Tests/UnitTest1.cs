using JenkinWebApplication;
using JenkinWebApplication.Controllers;

namespace WeatherForecastapi.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetData()
        {
            //Arrange
            var weatherForecast = new WeatherForecastController();

            //Act
            var result = weatherForecast.Get();

            //Assert
            Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
        }
    }
}