using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSamples.Models;

public partial class AccordionItem : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _description;

    [ObservableProperty]
    private bool _selected;
}