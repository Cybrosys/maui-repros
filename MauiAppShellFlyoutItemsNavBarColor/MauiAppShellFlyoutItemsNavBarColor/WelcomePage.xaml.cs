namespace MauiAppShellFlyoutItemsNavBarColor;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Dispatcher.Dispatch(async () =>
		{
			await Shell.Current.GoToAsync("//MainPage");
		});
    }
}