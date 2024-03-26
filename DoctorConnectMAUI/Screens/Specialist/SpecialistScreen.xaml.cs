
using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.Specialist;

public partial class SpecialistScreen : ContentPage
{
    public ObservableCollection<Doctor> doctors { get; set; }
	public SpecialistScreen()
	{
		InitializeComponent();
        Random random = new Random();

        // Predefined arrays for location and duration
        string[] names = {"Dr. Ronan Peiterson","Dr. Brayden Trump","Dr.Appollonia Ellison","Dr. Beatriz Watson","Dr. Stepheney Estey" };
        int[] expirences = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        double[] ratings = {4.9,4.7,4.8,4.2};
        int[] reviews = { 135, 235, 70, 42, 129 };
        doctors = new ObservableCollection<Doctor>();

        // Create 20 Book objects with random values and add them to the list
        for (int i = 1; i <= 7; i++)
        {
            // Generate random values
            string randomName = names[random.Next(names.Length)];
            string randomExpirence = expirences[random.Next(expirences.Length)].ToString();
            string randomRating = ratings[random.Next(ratings.Length)].ToString();
            string randomReview = reviews[random.Next(reviews.Length)].ToString();


            // Create Book object with random values and add to list
            doctors.Add(new Doctor
            {
                Image = $"doctor{i}.png",
                Name = randomName,  
                Experience = $"{randomExpirence} Years Experience",
                Review = $"{randomReview} Reviews",
                Rating = randomRating
            });
        }
        BindingContext = this;
    }
}

public class Doctor
{
    public string? Name { get; set; }
    public string? Image { get; set; }
    public string? Experience { get; set; }
    public string? Review { get; set; }
    public string? Rating { get; set; }
}