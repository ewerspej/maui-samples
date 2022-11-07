namespace MauiSamples;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_OnPressed(object sender, EventArgs e)
    {
#if ANDROID
        await DisplayAlert("Hello", "Hello from Android!", "OK");
#elif IOS
        await DisplayAlert("Hello", "Hello from iOS!", "OK");
#elif WINDOWS
        await DisplayAlert("Hello", "Hello from Windows!", "OK");
#else
        await DisplayAlert("Hello", "Hello from another platform (MacCatalyst, Tizen, ...)", "OK");
#endif
    }
}

