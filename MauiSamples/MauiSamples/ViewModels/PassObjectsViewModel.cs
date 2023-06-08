using CommunityToolkit.Mvvm.ComponentModel;
using MauiSamples.Models;

namespace MauiSamples.ViewModels;

[QueryProperty(nameof(Name), nameof(Name))]
[QueryProperty(nameof(Age), nameof(Age))]
[QueryProperty(nameof(IsMarried), nameof(IsMarried))]
public partial class PassObjectsViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private Person _somebody;

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private int _age;

    [ObservableProperty]
    private bool _isMarried;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Somebody = query[nameof(Somebody)] as Person;
    }
}