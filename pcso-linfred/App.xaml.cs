using pcso_linfred.View;
namespace pcso_linfred;


public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        Shell.Current.GoToAsync("//Login");
    }
}