using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

/// <summary>
/// Validates that an enum value is defined in the enum type.
/// </summary>
/// <typeparam name="TEnum">The enum type to validate.</typeparam>
public class EnumValidator<TEnum> : IValidator<TEnum> where TEnum : Enum
{
    public void Validate(TEnum value)
    {
        if (!Enum.IsDefined(typeof(TEnum), value))
            throw new ArgumentInvalidEnumException(nameof(value), value, typeof(TEnum));
    }
}