using CommunityToolkit.Maui;
using epj.Expander.Maui;
using epj.RouteGenerator;
using Maui.FixesAndWorkarounds;
using MauiSamples.Services;
using MauiSamples.Services.Audio;
using MauiSamples.Services.Device;
using MauiSamples.Services.Device.Platform;
using MauiSamples.ViewModels;
using MauiSamples.Views;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;

namespace MauiSamples;

[AutoRoutes("Page")]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMediaElement()
            .ConfigureMopups()
            .ConfigureMauiWorkarounds()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("MaterialIconsOutlined-Regular.otf", "MaterialIconsOutlined-Regular");
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons-Regular");
                fonts.AddFont("Strande2.ttf", "Strande2");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<IDeviceService>(DeviceService.Instance);
        builder.Services.AddSingleton<IAudioService, AudioService>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<BindingsViewModel>();
        builder.Services.AddTransient<BindingsPage>();

        var app = builder.Build();

        ServiceHelper.Initialize(app.Services);
        Expander.EnableAnimations();

        return app;
    }
}
