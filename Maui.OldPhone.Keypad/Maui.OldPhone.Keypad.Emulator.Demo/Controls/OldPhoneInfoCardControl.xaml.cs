namespace Maui.OldPhone.Keypad.Emulator.Demo.Controls;

public partial class OldPhoneInfoCardControl : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(OldPhoneInfoCardControl), string.Empty, defaultBindingMode: BindingMode.TwoWay);
    public static readonly BindableProperty InfoProperty = BindableProperty.Create(nameof(Info), typeof(string), typeof(OldPhoneInfoCardControl), string.Empty, defaultBindingMode: BindingMode.TwoWay);

    public OldPhoneInfoCardControl()
    {
        InitializeComponent();
    }

    public string Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }

    public string Info
    {
        get => GetValue(InfoProperty) as string;
        set => SetValue(InfoProperty, value);
    }
}