namespace WeatherApp.Tests.Services
{
  using Microsoft.VisualStudio.TestTools.UnitTesting;
  using WeatherApp.Services;

  [TestClass]
  public class WeatherForecastServiceTests
  {
    [TestMethod]
    public void Should_return_forecast_for_coords()
    {
      // Arrange
      var service = new WeatherForecastService();
      const double latitude = 59.334415;
      const double longitude = 18.110103;

      // Act
      var forecast = service.GetForecastByCoords(latitude, longitude);

      // Assert
      Assert.IsNotNull(forecast);      
    }
  }
}