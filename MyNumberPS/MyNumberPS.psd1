@{
    RootModule = 'MyNumberPS.dll'
    ModuleVersion = '1.2.3.0'
    FunctionsToExport = @(
            'Get-MyNumber'
            'Test-MyNumber'
            'Get-MyNumberRange'
        )
    CmdletsToExport   = '*'
    VariablesToExport = '*'
    AliasesToExport   = '*'
    GUID = 'de6fc708-4172-4685-abf4-2cd5930e6ba9'
    Author = 'Hideki Saito'
    Description = 'MyNumber Module for PowerShell'
    PowerShellVersion = '6.0'
    CompatiblePSEditions = 'Core'
    Copyright = '(c) 2019 Hideki Saito. All rights reserved.'
    PrivateData = @{
        PSData = @{
            ProjectUri = 'https://github.com/hsaito/MyNumberPS/'
            ReleaseNotes = ''
        }
    }
}
