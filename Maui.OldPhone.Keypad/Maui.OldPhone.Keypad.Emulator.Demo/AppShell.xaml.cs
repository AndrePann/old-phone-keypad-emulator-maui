using Maui.OldPhone.Keypad.Emulator.Demo.Views;

namespace Maui.OldPhone.Keypad.Emulator.Demo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ParserDemoPage), typeof(ParserDemoPage));
        }
    }
}