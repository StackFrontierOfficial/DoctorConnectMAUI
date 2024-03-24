namespace DoctorConnectMAUI.Screens.Auth;

public partial class VerificationScreen : ContentPage
{
    public Color bgColor { get; set; }
    public Color btnColor { get; set; }
    public bool showAlert { get; set; }
    public VerificationScreen()
    {
        InitializeComponent();
        bgColor = Color.FromRgba(255, 255, 255, 0.3);
        btnColor = Color.FromRgba(62, 108, 147, 220);
        showAlert = false;
        BindingContext = this;
    }

    private async void Submit_Clicked(object sender, EventArgs e)
    {
        alertDisplay.IsVisible = true;

        int durationMilliseconds = 3000;

        // Start a timer to hide the label after the specified duration
        await Task.Delay(durationMilliseconds);
        alertDisplay.IsVisible = false;
    }
}