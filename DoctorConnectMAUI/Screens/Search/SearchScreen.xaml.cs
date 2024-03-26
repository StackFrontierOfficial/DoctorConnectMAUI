using System.Collections.ObjectModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace DoctorConnectMAUI.Screens.Search;

public partial class SearchScreen : ContentPage
{
	public ObservableCollection<Category> Categories { get; set; }
	public SearchScreen()
	{
		InitializeComponent();
        Random random = new Random();

        // Predefined arrays for location and duration
        string[] locations = { "Dental Care",
        "Mental Health",
        "Nutrition",
        "Fitness",
        "Heart Health",
        "Women's Health",
        "Men's Health",
        "Pediatrics",
        "Dermatology",
        "Alternative Medicine",
        "Aging",
        "Chronic Diseases",
        "Infectious Diseases",
        "Reproductive Health",
        "Sleep Disorders",
        "Vision Care",
        "Substance Abuse",
        "Cancer",
        "Physical Therapy",
        "Genetics"};


        Categories = new ObservableCollection<Category>();

        // Create 20 Book objects with random values and add them to the list
        for (int i = 1; i <= 20; i++)
        {
            // Generate random values
            string randomLocation = locations[random.Next(locations.Length)];


            // Create Book object with random values and add to list
            Categories.Add(new Category
            {
                CategoryTitle = randomLocation
            });
        }
        BindingContext = this;
    }
}

public class Category
{
    public string? CategoryTitle { get; set; }
}