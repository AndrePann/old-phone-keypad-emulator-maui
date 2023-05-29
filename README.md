# old-phone-keypad-emulator-maui
A C# library as an emulator for an old phone keypad to translate the input string of digits, spaces, asterisks, and which ends with a route, into a resulting output for sending over a phone, as a cross platform application.

![Buil and Test](https://github.com/AndrePann/old-phone-keypad-emulator-maui/actions/workflows/dotnet-desktop.yml/badge.svg)

## Introduction
This application is an additional implementation, based on the emulator dll from the “old-phone-keypad-emulator” project and is intended to show the implementation as a cross platform solution.

## System requirements
* Visual Studio 2022
* .Net 7
* CommunityToolkit.Maui 
* CommunityToolkit.Mvvm 
* Microsoft.Extensions.Logging.Debug 
* NUnit Framework
  * NUnit3TestAdapter
  * NUnit.Analyzers
  * Microsoft.NET.Test.sdk
  * NSubstitute
  * coverlet.collector

## Architecture
The solution consists of four projects. 
The Maui.OldPhone.Keypad.Emulator, it is the interface dll based on the project “old-phone-keypad-emulator” that contains all the processing logic and is used only via a public method OldPhonePad. The input string is passed to this method as a parameter and it returns the parsed string as the return value for as output.
The second project is the Maui.OldPhone.Keypad.Emulator.Demo, it is an cross platform application, based on the MAUI Framework. 

It points the implementation technics:
* Cross platform solution with MAUI Framework
* MVVM pattern
* Micro services
* Custom controls
* Dependency injection
* Platform specific styles for each platform

The third and fourth project are Unit test projects for testing the Emulator dll and the cross platform Demo application.

It points to:
* Unit testing with NUnit
* Unit testing a MAUI Application
* Test cases for Service execution test
* Test cases for Command execution test

## Implementation
Since this is an additional implementation based on the emulator dll, only the implementation of the cross-platform application will be discussed here. 

The entry point is the CreateMauiApp method in the MauiProgram class. In the constructor of the app, the ShellApp page is created and the landing page is loaded. 

Each page is injected with the corresponding ViewModel via konstruktur injection and passed to the BindingContext. 

All techniques used have been kept as simple as possible to focus on the essentials and avoid unnecessary implementation code. 

All essential passages are additionally provided with comments. The implementation logic is kept as simple and self-explanatory as possible. 

However, if there are any questions, I will be happy to answer them, if I am able to do so.

## License
MIT


