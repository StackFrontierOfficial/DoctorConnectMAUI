﻿using DoctorConnectMAUI.Screens.AboutUs;
using DoctorConnectMAUI.Screens.Appointments;
using DoctorConnectMAUI.Screens.Auth;
using DoctorConnectMAUI.Screens.Chat;
using DoctorConnectMAUI.Screens.ConsultationDetail;
using DoctorConnectMAUI.Screens.DoctorProfile;
using DoctorConnectMAUI.Screens.EditProfile;
using DoctorConnectMAUI.Screens.Home;
using DoctorConnectMAUI.Screens.LabAndTestCheckup;
using DoctorConnectMAUI.Screens.Logout;
using DoctorConnectMAUI.Screens.Notifications;
using DoctorConnectMAUI.Screens.PatientDirectory;
using DoctorConnectMAUI.Screens.PaymentMethod;
using DoctorConnectMAUI.Screens.Profile;
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

			MainPage = new LogoutScreen();
			//MainPage = new NotificationEmpty();
			//MainPage = new NotificationDelete();
			//MainPage = new NotificationScreen();
			//MainPage = new AboutUsScreen();
			//MainPage = new PatientDirectoryScreen();
			//MainPage = new ChangePhoneNumber();
			//MainPage = new ChangeEmail();
			//MainPage = new ChangePassword();
			//MainPage = new ChaneName();
			//MainPage = new ChangeProfilePicture();
			//MainPage = new EditProfileScreen();
			//MainPage = new ProfileScreen();
			//MainPage = new Chat();
			//MainPage = new ChatScreen();
			//MainPage = new NoActiveAppointments();
			//MainPage = new CancelledAppointments();
			//MainPage = new AppointmentStatus();
			//MainPage = new AppointmentScreen();
			//MainPage = new LabTestAndHealthCheckUpScreen();
			//MainPage = new ReviewScreen();
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
