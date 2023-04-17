using JenkinWebApplication.Controllers;


namespace WeatherForecast.Test
{
    public class WeatherForecastTest
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