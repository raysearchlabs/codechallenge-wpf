namespace WeatherApp.ViewModels
{
  public class MainViewModel : ViewModel
  {
    public MainViewModel()
    {
      Title = "Code Callenge Weather App";
      MapViewModel = new MapViewModel(59.326142, 17.9875455, 8.0);
    }

    public string Title { get; private set; }

    public MapViewModel MapViewModel { get; private set; }
  }
}