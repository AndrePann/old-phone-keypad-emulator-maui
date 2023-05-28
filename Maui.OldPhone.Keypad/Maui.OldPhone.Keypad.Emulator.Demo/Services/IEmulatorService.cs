using Maui.OldPhone.Keypad.Emulator.Demo.Models;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Services;

/// <summary>
/// interface for the emulator service
/// </summary>
public interface IEmulatorService
{
    /// <summary>
    /// emulator service instance definition
    /// </summary>
    EmulatorService Instance { get; set; }

    /// <summary>
    /// predefined sample data object definition
    /// </summary>
    PreDefinedSample PreDefinedSampleData { get; set; }

    /// <summary>
    /// input value definition
    /// </summary>
    string InputValue { get; set; }

    /// <summary>
    /// sample data object definition
    /// </summary>
    SampleData Sample { get; set; }
    
    /// <summary>
    /// parse input data definition
    /// </summary>
    /// <param name="inputData"></param>
    /// <returns></returns>
    string ParseInputData(string inputData);
}