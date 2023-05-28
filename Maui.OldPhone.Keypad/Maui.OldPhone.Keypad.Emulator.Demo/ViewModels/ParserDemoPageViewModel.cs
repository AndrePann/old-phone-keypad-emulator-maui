using CommunityToolkit.Mvvm.ComponentModel;
using Maui.OldPhone.Keypad.Emulator.Demo.Models;
using Maui.OldPhone.Keypad.Emulator.Demo.Services;
using System.ComponentModel;
using System.Windows.Input;

namespace Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;

/// <summary>
/// parser demo page view model class
/// </summary>
public partial class ParserDemoPageViewModel : BaseViewModel
{
    /// <summary>
    /// constructor with injected navigation service
    /// </summary>
    /// <param name="navigationService"></param>
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

    /// <summary>
    /// parse input command to execut parse action
    /// </summary>
    public ICommand ParsInputCommand { private set; get; }
    /// <summary>
    /// input changed command to reset parse output and check command can execute
    /// </summary>
    public ICommand InputChangedCommand { private set; get; }

    /// <summary>
    /// page title property for data binding
    /// </summary>
    [ObservableProperty]
    private string _pageTitle;
    /// <summary>
    /// is enabled property for data binding
    /// </summary>
    [ObservableProperty]
    private bool _isEnabled;
    /// <summary>
    /// emulator service property for action call
    /// </summary>
    [ObservableProperty]
    private EmulatorService _emulatorService;
    /// <summary>
    /// sample data property for data binding as item source for the combobox
    /// </summary>
    [ObservableProperty]
    private List<SampleData> _sampleData;
    /// <summary>
    /// selected sample data property for data binding as selected item
    /// </summary>
    [ObservableProperty]
    private SampleData _selectedSampleData;
    /// <summary>
    /// parsed output property for data binding 
    /// </summary>
    [ObservableProperty]
    private string _parsedOutput;


    /// <summary>
    /// refresh can execute to check if command can be execute
    /// </summary>
    void RefreshCanExecutes()
    {
        (ParsInputCommand as Command).ChangeCanExecute();
    }

}