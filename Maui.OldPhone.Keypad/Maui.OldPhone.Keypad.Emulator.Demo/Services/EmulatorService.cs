using CommunityToolkit.Mvvm.ComponentModel;
using Maui.OldPhone.Keypad.Emulator.Demo.Models;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Services;

public class EmulatorService : ObservableObject, IEmulatorService
{
    public EmulatorService()
    {
        PreDefinedSampleData = new PreDefinedSample();
        Sample = PreDefinedSampleData.Get(AppPreDefinedSample.Sample_One);
    }

    private EmulatorService _instance;
    public EmulatorService Instance
    {
        get => _instance ??= new EmulatorService();
        set
        {
            if (SetProperty(ref _instance, value))
            {
                OnPropertyChanged(nameof(Instance));
                InputValue = _instance.InputValue;
            }
        }
    }

    private PreDefinedSample _preDefinedSampleData;
    public PreDefinedSample PreDefinedSampleData
    {
        get => _preDefinedSampleData;
        set
        {
            if (SetProperty(ref _preDefinedSampleData, value))
            {
                OnPropertyChanged(nameof(PreDefinedSampleData));
            }
        }
    }

    private string _inputValue;
    public string InputValue
    {
        get => _inputValue;
        set
        {
            if (SetProperty(ref _inputValue, value))
            {
                OnPropertyChanged(nameof(InputValue));
            }
        }
    }

    private SampleData _sample;
    public SampleData Sample
    {
        get => _sample;
        set
        {
            if (SetProperty(ref _sample, value))
            {
                OnPropertyChanged(nameof(Sample));
            }
        }
    }

    public string ParseInputData(string inputData)
    {
        var output = OldPhone.OldPhonePad(inputData);

        return output;
    }
}