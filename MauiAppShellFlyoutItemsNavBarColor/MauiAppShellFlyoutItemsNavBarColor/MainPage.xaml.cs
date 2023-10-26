namespace MauiAppShellFlyoutItemsNavBarColor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Dispatcher.Dispatch(async () =>
		{
			await Shell.Current.GoToAsync("//StartupPage/WelcomePage");
		});
    }
}