using Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Views;

public partial class ParserDemoPage : ContentPage
{
    public ParserDemoPage(ParserDemoPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}