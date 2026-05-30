using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's Status.
/// </summary>
/// <param name="status">The Status of the entity.</param>
public class Status<TEnum>(TEnum status) : ValueObject<TEnum>(new StatusValidator<TEnum>(), status)
    where TEnum : Enum;
