---
external help file: MyNumberPS.dll-Help.xml
Module Name: MyNumberPS
online version:
schema: 2.0.0
---

# Get-MyNumber

## SYNOPSIS
Gets randomly generated MyNumber.

## SYNTAX

```
Get-MyNumber [-String] [<CommonParameters>]
```

## DESCRIPTION
The `Get-MyNumber` cmdlet gets the randomized MyNumber for testing. Result is generated as MyNumberData which capsulates integer array.)

## EXAMPLES

### Example 1: Get random MyNumber
```powershell
Get-MyNumber
```

## PARAMETERS

### -String
Generate MyNumber in string format.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### System.Int32[]
Array of MyNumber digits in integer.

### System.String
If you use the `-String` parameter, `Get-MyNumber` returns MyNumber as a string.

## NOTES

## RELATED LINKS
[Get-MyNumberRange](Get-MyNumberRange)
[Test-MyNumber](Test-MyNumber)