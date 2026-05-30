using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's username.
/// </summary>
/// <param name="name">The username of the entity.</param>
public class Street(string street) : ValueObject<string>(new StreetValidator(), street);