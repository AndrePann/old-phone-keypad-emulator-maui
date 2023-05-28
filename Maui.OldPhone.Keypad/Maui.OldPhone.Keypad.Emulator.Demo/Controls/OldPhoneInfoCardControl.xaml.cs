namespace Maui.OldPhone.Keypad.Emulator.Demo.Controls;

/// <summary>
/// Custom info card control class
/// </summary>
public partial class OldPhoneInfoCardControl : ContentView
{
    /// <summary>
    /// bindable property for the title section of the control
    /// </summary>
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(OldPhoneInfoCardControl), string.Empty, defaultBindingMode: BindingMode.TwoWay);
    
    /// <summary>
    /// bindable property for the info section of the control
    /// </summary>
    public static readonly BindableProperty InfoProperty = BindableProperty.Create(nameof(Info), typeof(string), typeof(OldPhoneInfoCardControl), string.Empty, defaultBindingMode: BindingMode.TwoWay);

    /// <summary>
    /// default constructor
    /// </summary>
    public OldPhoneInfoCardControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Title property is binded to the text element of the first lable of the control
    /// </summary>
    public string Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }

    /// <summary>
    /// Info property is binded to the text element of the second lable of the control
    /// </summary>
    public string Info
    {
        get => GetValue(InfoProperty) as string;
        set => SetValue(InfoProperty, value);
    }
}