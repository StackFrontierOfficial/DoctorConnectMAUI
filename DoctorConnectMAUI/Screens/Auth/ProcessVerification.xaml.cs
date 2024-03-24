namespace DoctorConnectMAUI.Screens.Auth;

public partial class ProcessVerification : ContentView
{
	public ProcessVerification()
	{
		InitializeComponent();
	}
    public static async Task ShowLoadingAlert(Page page, string title = null)
    {
        var loadingAlert = new ProcessVerification();

        var customAlert = new ContentPage
        {
            Content = loadingAlert,
            Title = title
        };

        await page.Navigation.PushModalAsync(new NavigationPage(customAlert));
    }
}