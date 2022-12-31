using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiSamples.ViewModels;

public partial class EventsViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<string> _items = new();

    public EventsViewModel()
    {
        Items.Add("hello");
        Items.Add("yeah");
        Items.Add("awesome");
    }

    [RelayCommand]
    private void ItemSelected(string item)
    {
        Console.WriteLine(item);
    }
}