using CommunityToolkit.Mvvm.ComponentModel;
using Maui.OldPhone.Keypad.Emulator.Demo.Services;

namespace Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

public class BaseViewModel : ObservableObject
{
    protected readonly INavigationService NavigationService;

    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    public BaseViewModel()
    {

    }
}