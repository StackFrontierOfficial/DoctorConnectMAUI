namespace DoctorConnectMAUI.Screens.PaymentMethod;

public partial class PaymentMethodScreen : ContentPage
{
	public PaymentMethodScreen()
	{
		InitializeComponent();
	}
    private  void Pay_Clicked(object sender, EventArgs e)
    {
        alertDisplay.IsVisible = true;
        paymentPage.BackgroundColor = Color.FromRgb(151,151,151);



    }
}