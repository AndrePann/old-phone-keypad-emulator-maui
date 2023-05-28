namespace Maui.OldPhone.Keypad.Emulator.Demo.Models;

public class SampleData
{
    public AppPreDefinedSample DemoSample { get; set; }
    public string DisplayName { get; set; }
    public string InputValue { get; set; }

    public string ParsedOutput { get; set; }

    public SampleData(AppPreDefinedSample sample, string displayName, string inputValue)
    {
        DemoSample = sample;
        DisplayName = displayName;
        InputValue = inputValue;
        ParsedOutput = string.Empty;
    }
}