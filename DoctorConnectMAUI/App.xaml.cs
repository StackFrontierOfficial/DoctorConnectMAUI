using DoctorConnectMAUI.Screens.Auth;
using DoctorConnectMAUI.Screens.Home;

namespace DoctorConnectMAUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new HomeScreen();
			//MainPage = new RegisterScreen();
			//MainPage = new VerificationScreen();
			//MainPage = new VerificationScreen();
			//MainPage = new WelcomeScreen();
			//MainPage = new CountryCode();
		}
	}
}
