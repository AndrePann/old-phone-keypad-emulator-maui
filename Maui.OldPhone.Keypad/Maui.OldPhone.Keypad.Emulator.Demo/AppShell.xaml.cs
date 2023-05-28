using Maui.OldPhone.Keypad.Emulator.Demo.Views;

namespace Maui.OldPhone.Keypad.Emulator.Demo
{
    /// <summary>
    /// shell class
    /// </summary>
    public partial class AppShell : Shell
    {
        /// <summary>
        /// constructor
        /// </summary>
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ParserDemoPage), typeof(ParserDemoPage));
        }
    }
}