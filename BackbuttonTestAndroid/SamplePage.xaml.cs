namespace BackbuttonTestAndroid;

public partial class SamplePage : ContentPage
{
	public SamplePage(string title)
	{
		InitializeComponent();
        lblTitle.Text = title;
	}

    protected override bool OnBackButtonPressed()
    {
        Navigation.PopAsync(true);
        return true;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
       Task.Delay(1000);
    }
}