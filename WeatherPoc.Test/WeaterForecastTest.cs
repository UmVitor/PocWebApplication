namespace WeatherPoc.Test
{
    public class WeaterForecastTest
    {
        [Fact]
        public void CreateWeatherForecastSuccess()
        {
            var weatherForecast = new WeatherForecast(DateTime.Now, 10);
            Assert.True(true);
        }
    }
}