using AliyaPay.Malaysia.Core.Services;
using AliyaPay.Malaysia.Infrastructure.Services;
using AliyaPay.Malaysia.UI.ViewModel;
using Exchange.Monitor.MAUI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;
using CommunityToolkit.Maui;

namespace AliyaPay.Malaysia.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddSingleton<IToasterService, ToasterService>();
            builder.Services.AddSingleton<IConfigurationService, ConfigurationService>();
            builder.Services.AddSingleton<ICurrentUserService, CurrentUserService>();
            builder.Services.AddTransient<IAuthenticationService, AuthenticationService>();
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("AliyaPay.Malaysia.UI.appsettings.json"))
            {
                var config = new ConfigurationBuilder().AddJsonStream(stream).Build();
                builder.Configuration.AddConfiguration(config);
            }

            return builder.Build();
        }
    }
}