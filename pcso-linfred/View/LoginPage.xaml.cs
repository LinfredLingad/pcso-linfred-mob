using pcso_linfred.ViewModel;
namespace pcso_linfred.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
    {
		InitializeComponent();
        BindingContext = loginViewModel;
    }
}