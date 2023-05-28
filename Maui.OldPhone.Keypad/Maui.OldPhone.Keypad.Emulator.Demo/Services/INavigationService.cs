namespace Maui.OldPhone.Keypad.Emulator.Demo.Services;

/// <summary>
/// interface for the navigation service
/// </summary>
public interface INavigationService
{
    /// <summary>
    /// navigate to method definition
    /// </summary>
    /// <param name="route">name of the route</param>
    /// <param name="parameters">navigation parameter</param>
    /// <returns>Task object</returns>
    Task NavigateToAsync(string route, IDictionary<string, object> parameters = null);

    /// <summary>
    /// generic method to get the view model for a page
    /// </summary>
    /// <typeparam name="T">the expected view model</typeparam>
    /// <returns>the view model object </returns>
    T GetPageViewModel<T>() where T : new();
}