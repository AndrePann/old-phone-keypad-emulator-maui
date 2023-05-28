using Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Views;

public partial class LandingPage : ContentPage
{
    public LandingPage(LandingPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}