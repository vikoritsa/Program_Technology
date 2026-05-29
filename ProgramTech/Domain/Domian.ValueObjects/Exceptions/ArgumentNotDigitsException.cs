namespace Domain.ValueObjects.Exceptions;

public class ArgumentNotDigitsException(string paramName, string value)
    : FormatException($"The \"{paramName}\" value \"{value}\" must contain only digits.")
{
    public string Value => value;
}