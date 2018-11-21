---
external help file: MyNumberPS.dll-Help.xml
Module Name: MyNumberPS
online version:
schema: 2.0.0
---

# Get-MyNumberRange

## SYNOPSIS
Gets MyNumber(s) from the range of values.

## SYNTAX

```
Get-MyNumberRange [-String] [-Minimum] <UInt64> [-Maximum] <UInt64> [<CommonParameters>]
```

## DESCRIPTION
The `Get-MyNumberRange` cmdlet gets MyNumber(s) from the ranges of the numbers.

## EXAMPLES

### Example 1: Get MyNumbers in range between 100000000000 and 100000000200 (in integer array format)
```powershell
Get-MyNumberRange -Minimum 100000000000 -Maximum 100000000200
```

### Example 2: Get MyNumbers in range between 100000000000 and 100000000200 (in string format)
```powershell
Get-MyNumberRange -Minimum 100000000000 -Maximum 100000000200 -String
```

## PARAMETERS

### -Maximum
Maximum value for MyNumber generation.

```yaml
Type: UInt64
Parameter Sets: (All)
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Minimum
Minimum value for MyNumber generation.

```yaml
Type: UInt64
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### System.Int32[][]
Array of array of MyNumber digits in integer.

### System.String
If you use the `-String` parameter, `Get-MyNumberRange` returns array of MyNumber as a string.

## NOTES

## RELATED LINKS
