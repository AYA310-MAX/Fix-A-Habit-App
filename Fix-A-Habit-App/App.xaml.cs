namespace HabitTrackerApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new SplashScreen1())
        {
            BarBackgroundColor = Color.FromArgb("#1a4d3d"),
            BarTextColor = Colors.White
        };
    }
}