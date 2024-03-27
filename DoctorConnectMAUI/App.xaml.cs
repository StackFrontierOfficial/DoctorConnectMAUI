﻿using DoctorConnectMAUI.Screens.Auth;
using DoctorConnectMAUI.Screens.ConsultationDetail;
using DoctorConnectMAUI.Screens.DoctorProfile;
using DoctorConnectMAUI.Screens.Home;
using DoctorConnectMAUI.Screens.PaymentMethod;
using DoctorConnectMAUI.Screens.Review;
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

			MainPage = new ReviewScreen();
			//MainPage = new DoctorProfileScreen();
			//MainPage = new PaymentMethodScreen();
			//MainPage = new ConsultationDetailScreen();
			//MainPage = new TimeSlotsScreen();
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
