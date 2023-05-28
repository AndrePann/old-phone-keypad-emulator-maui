using Maui.OldPhone.Keypad.Emulator.Demo.Services;
using Maui.OldPhone.Keypad.Emulator.Demo.ViewModels;
using NSubstitute;

namespace Maui.OldPhone.Keypad.Emulator.Demo.Test
{
    public class ParserDemoPageViewModelTest
    {
        [Test]
        public void Emulator_Service_Parse_Valid_Input_Data()
        {
            // Arrange
            var nav = Substitute.For<INavigationService>();
            var vm = new ParserDemoPageViewModel(nav);

            // Act
            var sampleData = vm.EmulatorService.PreDefinedSampleData.AvailableSamples;
            string output = vm.EmulatorService.ParseInputData("22*#");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(sampleData.Count, Is.EqualTo(4));
                Assert.That(output, Is.EqualTo("A"));
            });
        }

        [Test]
        public void ParsInputCommand_Execution_Valid_Input()
        {
            // Arrange
            var nav = Substitute.For<INavigationService>();
            var vm = new ParserDemoPageViewModel(nav);

            // Act
            bool canExecuteBefore = vm.ParsInputCommand.CanExecute(null);
            vm.ParsInputCommand.Execute(null);
            string output = vm.ParsedOutput;
            bool canExecuteAfter = vm.ParsInputCommand.CanExecute(null);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(canExecuteBefore);
                Assert.That(output, Is.EqualTo("E"));
                Assert.IsFalse(canExecuteAfter);
            });
        }

        [Test]
        public void CanExecute_ParsInputCommand_True()
        {
            // Arrange
            var nav = Substitute.For<INavigationService>();
            var vm = new ParserDemoPageViewModel(nav);

            // Act
            vm.SelectedSampleData.InputValue = "22#";
            bool canExecute = vm.ParsInputCommand.CanExecute(null);

            // Assert
            Assert.IsTrue(canExecute);
        }

        [Test]
        public void CanExecute_ParsInputCommand_False()
        {
            // Arrange
            var nav = Substitute.For<INavigationService>();
            var vm = new ParserDemoPageViewModel(nav);

            // Act
            vm.SelectedSampleData.InputValue = "22";
            bool canExecute = vm.ParsInputCommand.CanExecute(null);

            // Assert
            Assert.IsFalse(canExecute);
        }
    }
}
