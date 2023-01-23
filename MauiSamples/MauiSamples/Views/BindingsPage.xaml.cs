using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class BindingsPage : ContentPage
{
    public BindingsPage(BindingsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}