using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

/// <summary>
/// Defines a method that implements the validation of the string.
/// </summary>
public class FlatValidator : IValidator<string>
{
    /// <summary>
    /// The Flat's max length
    /// </summary>
    public static int MAX_LENGTH => 10;

    /// <param name="value">A string containing data.</param>
    /// <exception cref="ArgumentLongValueException"></exception>
    public void Validate(string value)
    {
        if (value.Length > MAX_LENGTH)
            throw new ArgumentLongValueException(nameof(value), value, MAX_LENGTH);
    }
}
