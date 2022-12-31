using MauiSamples.ViewModels;

namespace MauiSamples.Views;

public partial class EventsPage : ContentPage
{
	public EventsPage()
	{
		InitializeComponent();
		BindingContext = new EventsViewModel();
	}

    //private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    //{
    //    throw new NotImplementedException();
    //}
}