using Microsoft.Extensions.Logging;
using MauiApp1.DependencyInjection;
using MauiApp1.DependencyInjection.ComponentModel;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSourceGeneratedServiceRegistration()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }


    public interface ICounterService
    {
        int Count();

        void Reset();
    }

    [Transient<ICounterService>]
    public class CounterService : ICounterService
    {
        int _count;

        public int Count() => ++_count;

        public void Reset() => _count = 0;
    }
}
