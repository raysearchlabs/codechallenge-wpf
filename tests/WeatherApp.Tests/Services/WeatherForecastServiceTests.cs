using WeatherApp.Services;

namespace WeatherApp.Tests.Services
{
  using Xunit;

  public class WeatherForecastServiceTests
  {
    [Fact]
    public void First_test()
    {
      // Arrange
      var service = new WeatherForecastService();
      const double latitude = 59.334415;
      const double longitude = 18.110103;

      // Act
      var forecast = service.GetForecastByCoords(latitude, longitude);

      // Assert
      Assert.NotNull(forecast);      
    }
  }
}