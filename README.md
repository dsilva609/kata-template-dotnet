# kata-template-dotnet
Starter template project to use for katas using .Net

### Prerequisites
- [.Net 7](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio](https://visualstudio.microsoft.com) (Preferred)

### Getting Started

Tests are using these libraries
- [xUnit](https://xunit.net)
- [NSubstitute](https://nsubstitute.github.io)
- [AutoFixture](https://github.com/AutoFixture/AutoFixture)


Make sure to build and restore the solution before running tests.

This template is separated into two projects `Kata.Template` and `Kata.Template.Tests`.

`Kata.Template` will be where any features you build are stored.

`Kata.Template.Tests` will be where you write your tests for those new features.
 These tests are currently organized under a `Unit` folder designating them as unit tests.
 (More folders for `e2e` or `integration` tests can be added later for further organization.)
 The `unit` folder is further organized to match the project structure of `Kata.Template` so you'll see the 
 sample test under `features`.