using MauiSamples.Views;

namespace MauiSamples;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MultiBindingPage), typeof(MultiBindingPage));
        Routing.RegisterRoute(nameof(PassObjectsPage), typeof(PassObjectsPage));
    }
}
