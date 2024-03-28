using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.Appointments;

public partial class CancelledAppointments : ContentPage
{
    public ObservableCollection<Appointment> activeAppointments { get; set; }
    public CancelledAppointments()
    {
        InitializeComponent();
        activeAppointments = new ObservableCollection<Appointment>()
        {
           
          
            new Appointment
           {
               DoctorName="Dr. Shira Gates",
               AppointmentTime = "5:00 PM",
               AppointmentDate="9 July 2020",
               Category="Nutrition"
           },
             new Appointment
           {
               DoctorName="Dr. Linnea Bezos",
               AppointmentTime = "1:30 PM",
               AppointmentDate="15 June 2020",
               Category="Cough & Fever"
           }
        };

        BindingContext = this;
    }
}