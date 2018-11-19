---
external help file: MyNumberPS.dll-Help.xml
Module Name: MyNumberPS
online version:
schema: 2.0.0
---

# Test-MyNumber

## SYNOPSIS
Verifies MyNumber for correctness.

## SYNTAX

```
Test-MyNumber [-MyNumberData] <Object> [-DataType <String>] [<CommonParameters>]
```

## DESCRIPTION
This command verifies if the supplied MyData is a correctly formatted number or not.

## EXAMPLES

### Example 1
```powershell
PS C:\> Test-MyNumber "************" -DataType string
```

This example checks to see if the number sequence supplied as a string is valid. (************ to be replaced with actual number to test.)

### Example 2
```powershell
PS C:\> $myNumberArray = *,*,*,*,*,*,*,*,*,*,*,*
PS C:\> Test-MyNumber $myNumberArray -DataType array
```

This example checks to see if the number sequence in integer array is valid. (* to be replaced with numerical digit.)

### Example 3
```powershell
PS C:\> Test-MyNumber $mydataArray
```

If you have previously generated MyNumberData array, it can be checked.

## PARAMETERS

### -DataType
Type of data input (data for MyNumberData, string for text string, and array for integer array

```yaml
Type: String
Parameter Sets: (All)
Aliases:
Accepted values: data, string, array

Required: False
Position: Named
Default value: data
Accept pipeline input: False
Accept wildcard characters: False
```

### -MyNumberData
MyNumber to test.

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### System.Boolean
## NOTES

## RELATED LINKS
