namespace MauiSamples;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_OnPressed(object sender, EventArgs e)
    {
        await this.SayHello();
    }
}

