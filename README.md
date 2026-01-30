# Dotfuscator Editor Emits Invalid Assembly Element When Excluding Input Assembly from Renaming

## Description
When excluding an entire input assembly from renaming using Dotfuscator Professional 7.5.0, the Dotfuscator Editor emits an invalid `<assembly>` element under the exclusion list. Specifically, the Editor introduces a `name` attribute on the `<assembly>` element that is not declared in the Dotfuscator XML schema. This causes command-line execution to fail validation.

## Repro Setup
- Dotfuscator Professional 7.5.0
- Solution contains three input assemblies:
  - LibraryAssembly1.dll
  - LibraryAssembly2.dll
  - WpfApp1.dll
- Only WpfApp1.dll is excluded from renaming
- Configuration is generated and saved using the Dotfuscator Editor

## Generated Configuration (Invalid)
```xml
<assembly name="${configdir}\..\WpfApp1\bin\Release\net10.0-windows\WpfApp1.dll">
  <file dir="" name="WpfApp1.dll" />
</assembly>
```

## Command-Line Execution
Build the DotfuscatorVer750_BadAttributes\Dotfuscator\dotfuscator.xml project file
```text
"C:\Program Files (x86)\PreEmptive Protection Dotfuscator Professional 7.5.0\dotfuscator.exe" dotfuscator.xml
```
See the result in DotfuscatorVer750_BadAttributes\Dotfuscator\CommandPromptOutput.txt

## Observed Error
```text
XML Validation error: The configuration file does not look like a valid Dotfuscator configuration file:
The 'name' attribute is not declared.
```

## Expected Behavior
The Dotfuscator Editor should emit schema-compliant XML. The `<assembly>` element under the exclusion list should not include a `name` attribute.

## Workaround
Manually removing the `name` attribute and unnecessary `<assembly>` sub-elements resolves the issue:

```xml
<assembly>
  <file dir="" name="WpfApp1.dll" />
</assembly>
```

## Additional Observation
- The Dotfuscator Editor itself builds successfully using the invalid configuration
- The failure occurs only when running Dotfuscator from the command line
- This indicates a mismatch between the Editor’s configuration generation and the command-line validator or schema enforcement

## Repro Repository
https://github.com/tracktownsoftware/DotfuscatorVer750_BadAttributes

Solution file:
DotfuscatorVer750_BadAttributes.sln
