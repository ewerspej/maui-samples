namespace MauiSamples.Navigation;

public interface INavigationService
{
    Task GoToAsync(ShellNavigationState state);
    Task GoToAsync(ShellNavigationState state, bool animate);
    Task GoToAsync(ShellNavigationState state, IDictionary<string, object> parameters);
    Task GoToAsync(ShellNavigationState state, bool animate, IDictionary<string, object> parameters);
    Task GoToAsync(ShellNavigationState state, ShellNavigationQueryParameters shellNavigationQueryParameters);
    Task GoToAsync(ShellNavigationState state, bool animate, ShellNavigationQueryParameters shellNavigationQueryParameters);
    Task GoBackAsync();
}