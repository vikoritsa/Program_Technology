using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

/// <summary>
/// Defines a method that implements the validation of the string.
/// </summary>
public class HouseValidator : IValidator<string>
{
    /// <summary>
    /// The House's max length
    /// </summary>
    public static int MAX_LENGTH => 10;

    /// <summary>
    /// The House's min length
    /// </summary>
    public static int MIN_LENGTH => 1;

    /// <summary>
    /// Verifies the string to make sure it is not null, empty or doesn't consists only white-space characters.
    /// </summary>
    /// <param name="value">A string containing data.</param>
    /// <exception cref="ArgumentNullOrWhiteSpaceException"></exception>
    /// <exception cref="ArgumentLongValueException"></exception>
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullOrWhiteSpaceException(nameof(value));

        if (value.Length > MAX_LENGTH)
            throw new ArgumentLongValueException(nameof(value), value, MAX_LENGTH);

        if (value.Length < MIN_LENGTH)
            throw new ArgumentShortValueException(nameof(value), value, MIN_LENGTH);
    }
}
