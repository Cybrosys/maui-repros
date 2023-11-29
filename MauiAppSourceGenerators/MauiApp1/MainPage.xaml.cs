using MauiApp1.DependencyInjection.ComponentModel;

namespace MauiApp1
{
    [Transient]
    public partial class MainPage : ContentPage
    {
        readonly ICounterService _counterService;

        public MainPage(ICounterService counterService)
        {
            InitializeComponent();
            _counterService = counterService;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var count = _counterService.Count();

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
