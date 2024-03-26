namespace DoctorConnectMAUI.Screens.Home;

public partial class HomeScreen : ContentPage
{
    public const uint AnimationDuration = 300;
    public bool isExpanded = false;
    
    public HomeScreen()
	{
		InitializeComponent();
        BindingContext = this;
	}


    //private void OnSwipeUp(object sender, SwipedEventArgs e)
    //{
    //    if (!isExpanded)
    //    {
    //        SwipeUpContentView.BackgroundColor = Colors.White;
    //        var frame = (Frame)sender;
    //        frame.VerticalOptions = LayoutOptions.FillAndExpand;
    //        frame.FadeTo(1, AnimationDuration, Easing.Linear);
    //        frame.TranslateTo(0, 0, AnimationDuration, Easing.Linear);
    //        isExpanded = true;
    //    }
    //}

    //private void OnSwipeDown(object sender, SwipedEventArgs e)
    //{
    //    if (isExpanded)
    //    {
    //        var frame = (Frame)sender;
    //        frame.VerticalOptions = LayoutOptions.End;
    //        frame.FadeTo(1, AnimationDuration, Easing.Linear);
    //        frame.TranslateTo(0, 0, AnimationDuration, Easing.Linear);
    //        SwipeUpContentView.BackgroundColor = Colors.Transparent;
    //        isExpanded = false;
    //    }
    //}
}