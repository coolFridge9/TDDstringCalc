# intro-to-tdd: C#

## prerequisites

Depending on which versino of .net core you have installed, you may need to manually set the `RuntimeFrameworkVersion` of the test project. To do this, run the following command:

```dotnet --version```

Edit the `src/IntroToTDD/IntroToTDD.Tests/IntroToTDD.Tests.csproj` file to reflect the version returned, eg:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    ...
    <RuntimeFrameworkVersion>2.0.5</RuntimeFrameworkVersion>
    ...
  </PropertyGroup>
 ...
</Project>
```

You may also have to restore packages by navigating to the solution directory (`src/IntroToTDD/`) and running the following command:

```dotnet restore```

## how to run tests

Navigate to the IntroToTDD.Tests directory (`src/IntroToTDD/IntroToTDD.Tests`) and run the following command:

```dotnet xunit```
