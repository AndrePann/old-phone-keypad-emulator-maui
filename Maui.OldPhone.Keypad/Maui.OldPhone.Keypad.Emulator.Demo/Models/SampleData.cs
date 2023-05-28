namespace Maui.OldPhone.Keypad.Emulator.Demo.Models;

/// <summary>
/// implementation of sample data object
/// </summary>
public class SampleData
{
    /// <summary>
    /// predefined sample data enum object
    /// </summary>
    public AppPreDefinedSample DemoSample { get; set; }
    /// <summary>
    /// the name of the sample for display in combobox
    /// </summary>
    public string DisplayName { get; set; }
    /// <summary>
    /// the value of the sample for input for the emulater
    /// </summary>
    public string InputValue { get; set; }

    /// <summary>
    /// property to take the parsed output from emulator logic
    /// </summary>
    public string ParsedOutput { get; set; }

    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="sample">predefined sample data enum object</param>
    /// <param name="displayName">the name of the sample data</param>
    /// <param name="inputValue">value of the dample data</param>
    public SampleData(AppPreDefinedSample sample, string displayName, string inputValue)
    {
        DemoSample = sample;
        DisplayName = displayName;
        InputValue = inputValue;
        ParsedOutput = string.Empty;
    }
}