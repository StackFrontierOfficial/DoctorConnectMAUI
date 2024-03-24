using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.Auth;

public partial class CountryCode : ContentPage
{
	public ObservableCollection<Country> countries { get; set; }
	public Color bgColor { get; set; }
	public Color btnColor { get; set; }
	public CountryCode()
	{
		InitializeComponent();
		Random random =  new Random();
		bgColor = Color.FromRgba(255, 255, 255, 0.3);
		btnColor = Color.FromRgba(62, 108, 147, 220);
		
		countries = new ObservableCollection<Country>();

		string[] countryNames = { "Afghanistan", "China", "Albania", "Algeria", "American Samoa", "Andorra", "Angola" };
		string[] countryFlags = { "afghanistan", "china", "albania", "algeria", "americansamoa", "angola","andorra"};

		for (int i = 0; i < 8; i++)
		{
			int randomIndex = random.Next(0, countryNames.Length);
			countries.Add(new Country
			{
				CountryName = countryNames[randomIndex],
				CountryFlag = $"{countryFlags[randomIndex]}.png"
			});
		}

		BindingContext = this;
	}
}

public class Country
{
    public string? CountryName { get; set; }
    public string? CountryFlag { get; set; }
}