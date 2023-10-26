namespace MauiAppShellFlyoutItemsNavBarColor
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("WelcomePage", typeof(WelcomePage));
        }
    }
}
