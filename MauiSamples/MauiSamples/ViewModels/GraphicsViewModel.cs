using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSamples.ViewModels;

public partial class GraphicsViewModel : ObservableObject
{
    [ObservableProperty]
    private double _radius = 50.0f;
}