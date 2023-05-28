using CommunityToolkit.Maui;
using Maui.OldPhone.Keypad.Emulator.Demo.Services;
using Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;
using Maui.OldPhone.Keypad.Emulator.Demo.Views;
using Microsoft.Extensions.Logging;

namespace Maui.OldPhone.Keypad.Emulator.Demo
{
    /// <summary>
    /// maui program as entry point for the application
    /// </summary>
    public static class MauiProgram
    {
        /// <summary>
        /// create maui app as entry point
        /// </summary>
        /// <returns></returns>
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            // service registration
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IEmulatorService, EmulatorService>();

            // view registration
            builder.Services.AddSingleton<LandingPage>();
            builder.Services.AddSingleton<ParserDemoPage>();

            // view model registration
            builder.Services.AddSingleton<LandingPageViewModel>();
            builder.Services.AddSingleton<ParserDemoPageViewModel>();

            return builder.Build();
        }
    }
}