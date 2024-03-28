using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.Appointments;

public partial class NoActiveAppointments : ContentPage
{
    public ObservableCollection<Appointment> activeAppointments { get; set; }
    public Color bgColor { get; set; }
    public NoActiveAppointments()
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
}