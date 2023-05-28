using Maui.OldPhone.Keypad.Emulator.Demo.Models;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Services;

public interface IEmulatorService
{
    EmulatorService Instance { get; set; }

    PreDefinedSample PreDefinedSampleData { get; set; }

    string InputValue { get; set; }

    SampleData Sample { get; set; }

    string ParseInputData(string inputData);
}