namespace Domain.ValueObjects.Exceptions;

public class ArgumentInvalidEnumException(string paramName, object value, Type enumType)
    : FormatException($"The \"{paramName}\" value '{value}' is not defined in enum '{enumType.Name}'. Valid values: {string.Join(", ", Enum.GetNames(enumType))}")
{
    public object Value => value;
    public Type EnumType => enumType;
}