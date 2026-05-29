using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

/// <summary>
/// Defines a method that implements the validation of the int.
/// </summary>
public class QuantityValidator : IValidator<int>
{
    /// <summary>
    /// The Quantity's min value
    /// </summary>
    public static int MIN_VALUE => 1;

    /// <param name="value">An int containing data.</param>
    /// <exception cref="ArgumentShortValueException"></exception>
    public void Validate(int value)
    {
        if (value < MIN_VALUE)
            throw new ArgumentShortValueException(nameof(value), value.ToString(), MIN_VALUE);
    }
}
