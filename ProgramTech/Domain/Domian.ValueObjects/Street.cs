using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's street.
/// </summary>
/// <param name="street">The street of the entity.</param>
public class Street(string street) : ValueObject<string>(new StreetValidator(), street);