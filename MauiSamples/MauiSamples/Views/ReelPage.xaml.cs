using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class ReelPage : ContentPage
{
    public ReelPage(ReelViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}