using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui.OldPhone.Keypad.Emulator.Demo.Services;
using Maui.OldPhone.Keypad.Emulator.Demo.Views;

namespace Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

public partial class LandingPageViewModel : BaseViewModel
{
    public LandingPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        PageTitle = "Old Phone Home";

        IntroTitle = "Old Phone Emulator Demo";
        PageIntro = "A C# library as an emulator for an old phone keypad to translate the input string of digits, spaces, asterisks, or routes into a resulting output for sending over a phone.";

        InfoTitle = "Description";
        PageInfo = "A C# library as an emulator for an old phone keypad to translate the input string of digits, spaces, asterisks, or routes into a resulting output for sending over a phone.";
    }

    [ObservableProperty]
    private string _pageTitle;

    [ObservableProperty]
    private string _introTitle;

    [ObservableProperty]
    private string _pageIntro;

    [ObservableProperty]
    private string _infoTitle;

    [ObservableProperty]
    private string _pageInfo;

    [RelayCommand]
    public void NavigateTo()
    {
        NavigationService.NavigateToAsync(nameof(ParserDemoPage));
    }
}