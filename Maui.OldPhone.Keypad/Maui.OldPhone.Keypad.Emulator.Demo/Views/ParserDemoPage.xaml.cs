using Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Views;

/// <summary>
/// parser page class
/// </summary>
public partial class ParserDemoPage : ContentPage
{
    /// <summary>
    /// constructor with injected view model
    /// </summary>
    /// <param name="viewModel">injected view model</param>
    public ParserDemoPage(ParserDemoPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}