using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.Chat;

public partial class ChatScreen : ContentPage
{
	public ObservableCollection<UserChat> chats { get; set; }
	public ChatScreen()
	{
		InitializeComponent();
		Random random = new Random();

		string[] doctorNames = { "Dr. Ronan Peiterson", "Dr. Brayden Trump", "Dr. Apollonia Ellison", "Dr. Beatriz Watson" };
		string[] messages = { "Hello, How can I help you?", "Okay", "Good", "Take Care"};
		string[] dates = { "1d ago", "1d ago", "5d ago", "1w ago","2d ago"};

        chats = new ObservableCollection<UserChat>();


        for (int i = 1; i < 10; i++)
		{
			string randomName = doctorNames[random.Next(0, doctorNames.Length)];
			string randomMessage = messages[random.Next(0, messages.Length)];
			string randomDate = dates[random.Next(0, dates.Length)];

			chats.Add(new UserChat
            {
                   DoctorImage = $"doctor{i}.png",
                   DoctorName = randomName,
				   LastMessage = randomMessage,
				   MessageDate = randomDate
			});
        }

		BindingContext = this;
	}
}

public class UserChat
{
    public string? DoctorImage { get; set; }
    public string? DoctorName { get; set; }
    public string? LastMessage { get; set; }
    public string? MessageDate { get; set; }
}