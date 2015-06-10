namespace WeatherApp
{
  using System.Windows;

  public partial class App
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);
      var bootstrapper = new Bootstrapper(this);
      bootstrapper.Run();
    }
  }
}