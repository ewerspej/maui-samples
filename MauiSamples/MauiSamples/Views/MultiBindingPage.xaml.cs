using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class MultiBindingPage : ContentPage
{
	public MultiBindingPage()
	{
		InitializeComponent();
        BindingContext = new MultiBindingViewModel();
    }
}