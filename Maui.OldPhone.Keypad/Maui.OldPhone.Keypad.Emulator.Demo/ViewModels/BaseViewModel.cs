using CommunityToolkit.Mvvm.ComponentModel;
using Maui.OldPhone.Keypad.Emulator.Demo.Services;

namespace Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

/// <summary>
/// base view model classe
/// </summary>
public class BaseViewModel : ObservableObject
{
    /// <summary>
    /// navigation service
    /// </summary>
    protected readonly INavigationService NavigationService;

    /// <summary>
    /// constructor with injected navigation service
    /// </summary>
    /// <param name="navigationService"></param>
    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    /// <summary>
    /// parameterless default constructor needed for mvvm pattern
    /// </summary>
    public BaseViewModel()
    {

    }
}