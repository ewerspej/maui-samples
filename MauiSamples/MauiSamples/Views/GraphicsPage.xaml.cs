using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class GraphicsPage
{
    public GraphicsPage()
    {
        InitializeComponent();
        BindingContext = new GraphicsViewModel();
    }
}