using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class MvvmSamplePage : ContentPage
{
    public MvvmSamplePage()
    {
        InitializeComponent();
        BindingContext = new MvvmSampleViewModel();
    }
}