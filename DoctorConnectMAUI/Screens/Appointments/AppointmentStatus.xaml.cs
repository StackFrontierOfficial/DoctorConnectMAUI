using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.Appointments;

public partial class AppointmentStatus : ContentPage
{
    public ObservableCollection<Appointment> activeAppointments { get; set; }
    public AppointmentStatus()
    {
        InitializeComponent();
        activeAppointments = new ObservableCollection<Appointment>()
        {
           new Appointment
           {
               DoctorName="Dr. Beatriz Watson",
               AppointmentTime = "10:30 AM",
               AppointmentDate="2 Oct 2020",
               Category="Dentist"
           },
           new Appointment
           {
               DoctorName="Dr. Beatriz Watson",
               AppointmentTime = "5:30 PM",
               AppointmentDate="25 Sept 2020",
               Category="Dentist"
           },
           new Appointment
           {
               DoctorName="Dr. Deigo Williams",
               AppointmentTime = "10:00 AM",
               AppointmentDate="20 Aug 2020",
               Category="General Physician"
           },
            new Appointment
           {
               DoctorName="Dr. Shira Gates",
               AppointmentTime = "10:00 AM",
               AppointmentDate="10 July 2020",
               Category="Nutrition"
           }
        };

        BindingContext = this;
    }
}