using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's number.
/// </summary>
/// <param name="number">The phonenumber of the entity.</param>
public class PhoneNumber(string number) : ValueObject<string>(new PhoneNumberValidator(), number);
