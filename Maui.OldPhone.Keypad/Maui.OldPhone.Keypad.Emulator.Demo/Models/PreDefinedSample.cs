namespace Maui.OldPhone.Keypad.Emulator.Demo.Models;

public sealed class PreDefinedSample
{
    public SampleData Sample_One = new(AppPreDefinedSample.Sample_One, "Sample <33#>", "33#");
    public SampleData Sample_Tow = new(AppPreDefinedSample.Sample_Two, "Sample <227*#>", "227*#");
    public SampleData Sample_Three = new(AppPreDefinedSample.Sample_Three, "Sample <4433555 555666#>", "4433555 555666#");
    public SampleData Sample_Four = new(AppPreDefinedSample.Sample_Four, "Sample <8 88777444666*664#>", "8 88777444666*664#");

    public List<SampleData> AvailableSamples { get; } = new();

    public AppPreDefinedSample DemoSample { get; }
    public string DisplayName { get; }
    public string InputValue { get; }

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