using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class MultiBinding : ContentPage
{
	public MultiBinding()
	{
		InitializeComponent();
        BindingContext = new MultiBindingViewModel();
    }
}