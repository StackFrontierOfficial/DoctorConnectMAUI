using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.Appointments;

public partial class AppointmentScreen : ContentPage
{
    public ObservableCollection<Appointment> activeAppointments { get; set; }
    public Color bgColor { get; set; }
	public AppointmentScreen()
	{
		InitializeComponent();
        bgColor = Colors.White;
        activeAppointments = new ObservableCollection<Appointment>()
        {
           new Appointment
           {
               DoctorName="Dr. Ronan Peiterson",
               AppointmentTime = "10:00 AM",
               AppointmentDate="15 Oct 2020",
               Category="General Physician"
           },
           new Appointment
           {
               DoctorName="Dr. Brayden Trump",
               AppointmentTime = "12:30 PM",
               AppointmentDate="16 Oct 2020",
               Category="Cardiologist"
           },
           new Appointment
           {
               DoctorName="Dr. Apollonia Ellison",
               AppointmentTime = "6:00 AM",
               AppointmentDate="22 Oct 2020",
               Category="Dentist"
           }
        };

        BindingContext = this;

    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
       await DisplayAlert("Are you sure you want to cancel this appointment?", "", "Yes", "No");
        
        //alertDisplay.IsVisible = true;
        //bgColor = Colors.Gray;
    }
}

public class Appointment
{
    public string? DoctorName { get; set; }
    public string? Category { get; set; }
    public string? AppointmentDate { get; set; }
    public string? AppointmentTime { get; set; }
}