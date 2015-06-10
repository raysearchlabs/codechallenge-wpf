namespace WeatherApp
{
  using System.Windows;
  using ViewModels;
  using Views;

  public class Bootstrapper
  {
    public Bootstrapper(Application app)
    {
      Application = app;      
    }

    public Application Application { get; private set; }

    public void Run()
    {
      var vm = new MainViewModel();
      var mainWindow = new MainWindow { DataContext = vm };
      mainWindow.Show();
    }
  }
}