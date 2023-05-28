using CommunityToolkit.Mvvm.ComponentModel;
using Maui.OldPhone.Keypad.Emulator.Demo.Models;
using Maui.OldPhone.Keypad.Emulator.Demo.Services;
using System.ComponentModel;
using System.Windows.Input;

namespace Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

public partial class ParserDemoPageViewModel : BaseViewModel
{

    public ParserDemoPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        PageTitle = "Old Phone Input Parser Demo";

        EmulatorService = new EmulatorService();
        _sampleData = EmulatorService.PreDefinedSampleData.AvailableSamples;
        _selectedSampleData = EmulatorService.PreDefinedSampleData.Get(AppPreDefinedSample.Sample_One);

        ParsInputCommand = new Command(
                            execute: () =>
                            {
                                var output = EmulatorService.ParseInputData(SelectedSampleData.InputValue);
                                ParsedOutput = output;
                                IsEnabled = true;
                                RefreshCanExecutes();
                            },
                                 canExecute: () =>
                                 {
                                     return string.IsNullOrEmpty(ParsedOutput) &&
                                     SelectedSampleData.InputValue != null &&
                                     SelectedSampleData.InputValue.EndsWith("#");
                                 });

        InputChangedCommand = new Command(
            execute: () =>
            {
                ParsedOutput = string.Empty;
                RefreshCanExecutes();
            });

    }

    [ObservableProperty]
    private string _pageTitle;

    [ObservableProperty]
    private bool _isEnabled;

    public ICommand ParsInputCommand { private set; get; }
    public ICommand InputChangedCommand { private set; get; }

    void OnPersonEditPropertyChanged(object sender, PropertyChangedEventArgs args)
    {
        (ParsInputCommand as Command).ChangeCanExecute();
    }

    void RefreshCanExecutes()
    {
        (ParsInputCommand as Command).ChangeCanExecute();
    }

    [ObservableProperty]
    private EmulatorService _emulatorService;

    [ObservableProperty]
    private List<SampleData> _sampleData;

    [ObservableProperty]
    private SampleData _selectedSampleData;

    [ObservableProperty]
    private string _parsedOutput;

}