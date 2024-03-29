using DoctorConnectMAUI.Screens.ConsultationDetail;
using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.PatientDirectory;

public partial class PatientDirectoryScreen : ContentPage
{
	public ObservableCollection<User> users { get; set; }
	public PatientDirectoryScreen()
	{
		InitializeComponent();


		users = new ObservableCollection<User>()
		{
			new User{Name="Allison Perry",UserImage="user3.jpg"},
			new User{Name="John Smith",UserImage="contact.png"}
		};

		BindingContext = this;

	}
}