namespace MauiSamples.Navigation;

public class NavigationService : INavigationService
{
    public Task GoToAsync(ShellNavigationState state) => Shell.Current.GoToAsync(state);
    public Task GoToAsync(ShellNavigationState state, bool animate) => Shell.Current.GoToAsync(state, animate);
    public Task GoToAsync(ShellNavigationState state, IDictionary<string, object> parameters) => Shell.Current.GoToAsync(state, parameters);
    public Task GoToAsync(ShellNavigationState state, bool animate, IDictionary<string, object> parameters) => Shell.Current.GoToAsync(state, animate, parameters);
    public Task GoToAsync(ShellNavigationState state, ShellNavigationQueryParameters shellNavigationQueryParameters) => Shell.Current.GoToAsync(state, shellNavigationQueryParameters);
    public Task GoToAsync(ShellNavigationState state, bool animate, ShellNavigationQueryParameters shellNavigationQueryParameters) => Shell.Current.GoToAsync(state, animate, shellNavigationQueryParameters);
    public Task GoBackAsync() => Shell.Current.GoToAsync("..");
}