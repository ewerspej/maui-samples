using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiSamples.ViewModels;

public partial class MultiBindingViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(SaveCommand))]
    private string _email;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(SaveCommand))]
    private string _phone;

    [RelayCommand(CanExecute = nameof(CanSave))]
    private void Save()
    {
        // your logic here
    }

    private bool CanSave() => !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Phone);
}