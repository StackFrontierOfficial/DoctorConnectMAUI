namespace DoctorConnectMAUI.Screens.Auth;

public partial class WelcomeScreen : ContentPage
{
	public Color bgColor { get; set; }
	public Color btnColor { get; set; }
	public WelcomeScreen()
	{
		InitializeComponent();
		bgColor = Color.FromRgba(255, 255, 255, 0.3);
		btnColor = Color.FromRgba(62, 108, 147, 220);
		BindingContext = this;
	}
}