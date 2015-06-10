namespace WeatherApp.Services.Model
{
  using System;
  
  public class Forecast
  {
    public double Lat { get; set; }
    public double Lon { get; set; }
    public DateTimeOffset ReferenceTime { get; set; }
    public TimeSeries[] TimeSeries { get; set; }

    public override string ToString()
    {
      return string.Format("ReferenceTime={0}, Latitude={1}, Longitude={2}", ReferenceTime, Lat, Lon);
    }
  }
}