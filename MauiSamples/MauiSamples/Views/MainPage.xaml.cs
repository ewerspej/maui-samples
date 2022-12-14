using MauiSamples.Services.Device.Platform;
using MauiSamples.ViewModels;
using MauiSamples.Views.Platform;

namespace MauiSamples.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel(DeviceService.Instance);
    }

    private async void SayHello(object sender, EventArgs e)
    {
#if ANDROID || IOS || MACCATALYST || WINDOWS
        await this.SayHello();
#endif
    }

    private async void OpenHelloView(object sender, EventArgs e)
    {
        //Conditional compilation approach (preferred)
#if ANDROID
        await Navigation.PushAsync(new HelloFromAndroid());
#elif IOS
        await Navigation.PushAsync(new HelloFromiOS());
#else
        await Navigation.PushAsync(new HelloFromOther());
#endif

        //Runtime approach
        //if (DeviceInfo.Platform == DevicePlatform.Android)
        //{
        //    await Navigation.PushAsync(new HelloFromAndroid());
        //}
        //
        //if (DeviceInfo.Platform == DevicePlatform.iOS)
        //{
        //    await Navigation.PushAsync(new HelloFromiOS());
        //}
    }

    private async void OpenWithPlatformView(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageWithPlatformSpecificView());
    }
}

