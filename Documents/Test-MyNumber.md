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

### Example 1: Check array of integer of MyNumber digits (* to be replaced with actual MyNumber digits.)
```powershell
$myNumberArray = *,*,*,*,*,*,*,*,*,*,*,*
Test-MyNumber $myNumberArray -DataType array
```

### Example 2: Check string of MyNumber digits (* to be replaced with actual MyNumber digits.)
```powershell
Test-MyNumber "************" -DataType string
```

## PARAMETERS

### -DataType
Type of data input (string for text string, and array for integer array)

```yaml
Type: String
Parameter Sets: (All)
Aliases:
Accepted values: string, array

Required: False
Position: Named
Default value: array
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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None
## OUTPUTS

### System.Boolean
`True` if MyNumber supplied is valid, `False` if not.

## NOTES

## RELATED LINKS

[Get-MyNumber](Get-MyNumber)
[Get-MyNumberRange](Get-MyNumberRange)