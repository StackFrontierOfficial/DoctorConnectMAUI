using DoctorConnectMAUI.Screens.Auth;

namespace DoctorConnectMAUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new WelcomeScreen();
			//MainPage = new CountryCode();
		}
	}
}
