namespace Maui.OldPhone.Keypad.Emulator.Demo.Services;

/// <summary>
/// implementation ot the navigation service
/// </summary>
public class NavigationService : INavigationService
{
    /// <summary>
    /// navigat to method
    /// </summary>
    /// <param name="route">name of the route</param>
    /// <param name="parameters">navigation parameter</param>
    /// <returns>task to navigate to the current route it registered</returns>
    public Task NavigateToAsync(string route, IDictionary<string, object> parameters = null)
    {
        if (parameters != null)
            return Shell.Current.GoToAsync(route, parameters);
        else
            return Shell.Current.GoToAsync(route);
    }

    /// <summary>
    /// generic method to get the view model for a page
    /// </summary>
    /// <typeparam name="T">the expected view model</typeparam>
    /// <returns>the view model object </returns>
    public T GetPageViewModel<T>() where T : new()
    {
        var pageDetails = Shell.Current.CurrentItem.CurrentItem.Stack.Where(f => f != null && f.BindingContext.GetType() == typeof(T)).FirstOrDefault();
        if (pageDetails != null)
        {
            return (T)pageDetails.BindingContext;
        }
        return default(T);
    }
}