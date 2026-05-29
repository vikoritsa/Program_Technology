using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

/// <summary>
/// Defines a method that implements the validation of the int.
/// </summary>
public class EntranceValidator : IValidator<int>
{
    /// <summary>
    /// The Entrance's min value
    /// </summary>
    public static int MIN_VALUE => 1;

    /// <summary>
    /// The Floor's max value
    /// </summary>
    public static int MAX_VALUE => 70;

    /// <param name="value">An int containing data.</param>
    /// <exception cref="ArgumentShortValueException"></exception>
    /// <exception cref="ArgumentLongValueException"></exception>
    public void Validate(int value)
    {
        if (value < MIN_VALUE)
            throw new ArgumentShortValueException(nameof(value), value.ToString(), MIN_VALUE);

        if (value > MAX_VALUE)
            throw new ArgumentShortValueException(nameof(value), value.ToString(), MAX_VALUE);
    }
}