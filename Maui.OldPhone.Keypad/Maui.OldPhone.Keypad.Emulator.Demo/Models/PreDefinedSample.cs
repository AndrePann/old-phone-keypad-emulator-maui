namespace Maui.OldPhone.Keypad.Emulator.Demo.Models;

/// <summary>
/// predefine sample data implentation as content for a combobox
/// </summary>
public sealed class PreDefinedSample
{
    /// <summary>
    /// sample one definition
    /// </summary>
    public SampleData Sample_One = new(AppPreDefinedSample.Sample_One, "Sample <33#>", "33#");
    /// <summary>
    /// sample two definition
    /// </summary>
    public SampleData Sample_Tow = new(AppPreDefinedSample.Sample_Two, "Sample <227*#>", "227*#");
    /// <summary>
    /// sample tree definition
    /// </summary>
    public SampleData Sample_Three = new(AppPreDefinedSample.Sample_Three, "Sample <4433555 555666#>", "4433555 555666#");
    /// <summary>
    /// sample four definition
    /// </summary>
    public SampleData Sample_Four = new(AppPreDefinedSample.Sample_Four, "Sample <8 88777444666*664#>", "8 88777444666*664#");

    /// <summary>
    /// list of aveilable sample definitions
    /// </summary>
    public List<SampleData> AvailableSamples { get; } = new();

    /// <summary>
    /// predefined sample data enum object
    /// </summary>
    public AppPreDefinedSample DemoSample { get; }
    /// <summary>
    /// the name of the sample for display in combobox
    /// </summary>
    public string DisplayName { get; }
    /// <summary>
    /// the value of the sample for input for the emulater
    /// </summary>
    public string InputValue { get; }

    /// <summary>
    /// constructor with initialisation of the list of available sample 
    /// </summary>
    public PreDefinedSample()
    {
        AvailableSamples.Add(Sample_One);
        AvailableSamples.Add(Sample_Tow);
        AvailableSamples.Add(Sample_Three);
        AvailableSamples.Add(Sample_Four);
    }

    private PreDefinedSample(AppPreDefinedSample sample, string displayName, string inputValue)
    {
        DemoSample = sample;
        DisplayName = displayName;
        InputValue = inputValue;
    }

    /// <summary>
    /// get a sample data object by predifine sample data enum object
    /// </summary>
    /// <param name="demoSample">the enum object for selection</param>
    /// <returns>the selected sample data object</returns>
    /// <exception cref="ArgumentOutOfRangeException">exception if the list doesn't contain the enum value as key</exception>
    public SampleData Get(AppPreDefinedSample demoSample)
    {
        return demoSample switch
        {
            AppPreDefinedSample.Sample_One => Sample_One,
            AppPreDefinedSample.Sample_Two => Sample_Tow,
            AppPreDefinedSample.Sample_Three => Sample_Three,
            AppPreDefinedSample.Sample_Four => Sample_Four,
            _ => throw new ArgumentOutOfRangeException(nameof(demoSample), demoSample, null)
        };
    }
}