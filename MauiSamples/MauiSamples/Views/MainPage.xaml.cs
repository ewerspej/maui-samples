using MauiSamples.Services.Device.Platform;
using MauiSamples.ViewModels;

namespace MauiSamples;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel(DeviceService.Instance);
    }

    private async void Button_OnPressed(object sender, EventArgs e)
    {
#if ANDROID || IOS || MACCATALYST || WINDOWS
        await this.SayHello();
#endif
    }
}

