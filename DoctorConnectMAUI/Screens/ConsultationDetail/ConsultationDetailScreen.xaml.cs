using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.ConsultationDetail;

public partial class ConsultationDetailScreen : ContentPage
{
    public ObservableCollection<User> users { get; set; }
    public ConsultationDetailScreen()
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

public class User
{
    public string? Name { get; set; }
    public string? UserImage { get; set; }
}