namespace Maui.OldPhone.Keypad.Emulator.Demo
{
    /// <summary>
    /// application page classe
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// constructor
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}