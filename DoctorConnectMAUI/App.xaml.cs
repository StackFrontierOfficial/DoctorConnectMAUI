using DoctorConnectMAUI.Screens.Auth;
using DoctorConnectMAUI.Screens.Home;
using DoctorConnectMAUI.Screens.Search;
using DoctorConnectMAUI.Screens.Specialist;
using DoctorConnectMAUI.Screens.TimeSlots;

namespace DoctorConnectMAUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new TimeSlotsScreen();
			//MainPage = new SpecialistScreen();
			//MainPage = new Speciality();
			//MainPage = new SearchScreen();
			//MainPage = new CitySelection();
			//MainPage = new HomeScreen();
			//MainPage = new RegisterScreen();
			//MainPage = new VerificationScreen();
			//MainPage = new VerificationScreen();
			//MainPage = new WelcomeScreen();
			//MainPage = new CountryCode();
		}
	}
}
