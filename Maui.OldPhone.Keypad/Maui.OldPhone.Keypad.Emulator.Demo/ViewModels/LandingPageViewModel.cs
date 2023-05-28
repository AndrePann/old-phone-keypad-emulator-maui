using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui.OldPhone.Keypad.Emulator.Demo.Services;
using Maui.OldPhone.Keypad.Emulator.Demo.Views;

namespace Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

/// <summary>
/// landing page view model class
/// </summary>
public partial class LandingPageViewModel : BaseViewModel
{
    /// <summary>
    /// consturtor with injected navigation service
    /// </summary>
    /// <param name="navigationService"></param>
    public LandingPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        PageTitle = "Old Phone Home";

        IntroTitle = "Old Phone Emulator Demo";
        PageIntro = "A C# library as an emulator for an old phone keypad to translate the input string of digits, spaces, asterisks, or routes into a resulting output for sending over a phone.";

        InfoTitle = "Description";
        PageInfo = "This application is an additional implementation, based on the emulator dll from the “old-phone-keypad-emulator” project and is intended to show the implementation as a cross platform solution. \n\nIt points the implementation technics: \n\n - Cross platform solution with MAUI Framework \n - MVVM pattern \n - Micro services \n - Custom controls \n - Dependency injection \n - Platform specific styles for each platform \n - Unit testing with NUnit \n - Unit testing a MAUI Application \n - Test cases for Service execution test \n - Test cases for Command execution test";
    }

    /// <summary>
    /// page title property for data binding
    /// </summary>
    [ObservableProperty]
    private string _pageTitle;
    /// <summary>
    /// intor title property for data binding
    /// </summary>
    [ObservableProperty]
    private string _introTitle;
    /// <summary>
    /// page intro property for data binding
    /// </summary>
    [ObservableProperty]
    private string _pageIntro;
    /// <summary>
    /// info title property for data binding
    /// </summary>
    [ObservableProperty]
    private string _infoTitle;
    /// <summary>
    /// page info property for data binding
    /// </summary>
    [ObservableProperty]
    private string _pageInfo;

    /// <summary>
    /// navigat to method to call the navigation service wit route name
    /// </summary>
    [RelayCommand]
    public void NavigateTo()
    {
        NavigationService.NavigateToAsync(nameof(ParserDemoPage));
    }
}