namespace DoctorConnectMAUI.Screens.Auth;

public partial class RegisterScreen : ContentPage
{
    public Color btnColor { get; set; }
    public Color continueBtnColor { get; set; }
    public RegisterScreen()
	{
		InitializeComponent();
        btnColor = Color.FromRgba(255, 255, 255, 0.3);
        continueBtnColor = Color.FromRgba(62, 108, 147, 220);

        BindingContext = this;
    }
}