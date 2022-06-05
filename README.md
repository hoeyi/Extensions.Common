# Ichosys.Extensions.Common #
This library contains extension methods for commonly-used types in .NET, primarily for types in the System namespace. 

* [Building Project](#building-prjoject)
* [Public API](#api)

Be sure to read the [guidelines for contributing](CONTRIBUTING.md) to this project.

## Building Project ##
By default, the project `$(BuildNumber)` property is set to zero. Uncomment the line `Extensions.Configuration.csproj` to allow auto-assignment of the build number. Once the build is complete, revert the change to the `$(BuilderNumber)` property assignment.

## API ##
This library maintains the following API for consumption:

### Extensions.Common.Localization
#### LocalizationExtension  #### 
`LocalizationExtension` provides extenions methods for converting nullable built-in types 
or presenting them as localized strings. ([source](\Extensions.Common\Localization\LocalizationExtension.cs))

###

### Extensions.Common.Logging
#### LocalizationExtension  ####
`LoggingExtension` provies extension methods for manipulating or interpolating strings. ([source](\Extensions.Common\Logging\LoggingExtension.cs))

###
