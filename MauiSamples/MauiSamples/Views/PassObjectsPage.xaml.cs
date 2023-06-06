using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class PassObjectsPage : ContentPage
{
    public PassObjectsPage()
    {
        InitializeComponent();
        BindingContext = new PassObjectsViewModel();
    }
}