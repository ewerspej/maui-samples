using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class BindingsPage
{
    public BindingsPage(BindingsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}