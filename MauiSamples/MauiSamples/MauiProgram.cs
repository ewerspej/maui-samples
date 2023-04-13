using CommunityToolkit.Maui;
using MauiSamples.ViewModels;
using MauiSamples.Views;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;

namespace MauiSamples;

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

        builder.Services.AddTransient<BindingsViewModel>();
        builder.Services.AddTransient<BindingsPage>();

        return builder.Build();
    }
}
