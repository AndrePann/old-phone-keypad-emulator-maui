namespace Maui.OldPhone.Keypad.Emulator.Demo.Services;

public class NavigationService : INavigationService
{
    public Task NavigateToAsync(string route, IDictionary<string, object> parameters = null)
    {
        if (parameters != null)
            return Shell.Current.GoToAsync(route, parameters);
        else
            return Shell.Current.GoToAsync(route);
    }

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