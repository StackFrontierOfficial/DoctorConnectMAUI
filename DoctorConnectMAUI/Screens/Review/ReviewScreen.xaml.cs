using System.Collections.ObjectModel;

namespace DoctorConnectMAUI.Screens.Review;

public partial class ReviewScreen : ContentPage
{
    public ObservableCollection<Review> Reviews { get; set; }
	public ReviewScreen()
	{
		InitializeComponent();
        Random random = new Random();

        string[] names = { "Ersel","Jane","Apollonia","Beatriz", "Randy" };
        string[] dates = { "August 2020","July 2020","June 2020", "April 2020" };
        string[] reviews = { "Really good doctor","Great doctor i have ever seen","Excellent","Really nice!" };

   

        Reviews = new ObservableCollection<Review>();

        for (int i = 1; i <= 8; i++)
        {
            string randomName = names[random.Next(0, names.Length)];
            string randomDate = dates[random.Next(0, dates.Length)];
            string randomReview = reviews[random.Next(0, reviews.Length)];

            Reviews.Add(new Review
            {
                 Name = randomName,
                ReviewDate = randomDate,
                UserImage = $"user{i}.jpg",
                 UserReview = randomReview
            });
        }

        BindingContext = this;

    }
}

public class Review
{
    public string? Name { get; set; }
    public string? UserImage { get; set; }
    public string? UserReview { get; set; }
    public string? ReviewDate { get; set; }
    
}