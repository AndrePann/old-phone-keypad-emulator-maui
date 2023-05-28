using CommunityToolkit.Mvvm.ComponentModel;
using Maui.OldPhone.Keypad.Emulator.Demo.Models;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Services;

/// <summary>
/// implementation of the emulator service class
/// </summary>
public class EmulatorService : ObservableObject, IEmulatorService
{
    #region fields
    private EmulatorService _instance;
    private PreDefinedSample _preDefinedSampleData;
    private string _inputValue;
    private SampleData _sample;

    #endregion // fields

    #region ctor

    /// <summary>
    /// constructor with initialisation
    /// </summary>
    public EmulatorService()
    {
        PreDefinedSampleData = new PreDefinedSample();
        Sample = PreDefinedSampleData.Get(AppPreDefinedSample.Sample_One);
    }

    #endregion // ctor

    #region properties

    /// <summary>
    /// emulator service instance object
    /// </summary>
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

    /// <summary>
    /// predefinted sample data object
    /// </summary>
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

    /// <summary>
    /// input value 
    /// </summary>
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

    /// <summary>
    /// sample data object
    /// </summary>
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

    #endregion // properties

    #region methods

    /// <summary>
    /// parse input data method
    /// </summary>
    /// <param name="inputData">input string</param>
    /// <returns>parsed output or error info</returns>
    public string ParseInputData(string inputData)
    {
        var output = OldPhone.OldPhonePad(inputData);

        return output;
    }

    #endregion // methods
}