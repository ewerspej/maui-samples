using MauiSamples.ViewModels;

namespace MauiSamples;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }
}

