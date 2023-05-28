using Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Views;

/// <summary>
/// landing page class
/// </summary>
public partial class LandingPage : ContentPage
{
    /// <summary>
    /// constructor with injected view model
    /// </summary>
    /// <param name="viewModel">injected view model</param>
    public LandingPage(LandingPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}