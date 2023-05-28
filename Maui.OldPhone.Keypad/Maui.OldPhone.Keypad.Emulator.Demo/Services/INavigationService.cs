namespace Maui.OldPhone.Keypad.Emulator.Demo.Services;

public interface INavigationService
{
    Task NavigateToAsync(string route, IDictionary<string, object> parameters = null);

    T GetPageViewModel<T>() where T : new();
}