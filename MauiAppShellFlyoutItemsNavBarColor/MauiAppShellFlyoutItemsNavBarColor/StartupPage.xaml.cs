namespace MauiAppShellFlyoutItemsNavBarColor;

public partial class StartupPage : ContentPage
{
	public StartupPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Dispatcher.Dispatch(async () =>
        {
            await Shell.Current.GoToAsync("WelcomePage");
        });
    }
}