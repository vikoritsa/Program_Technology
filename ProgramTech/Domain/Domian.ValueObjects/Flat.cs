using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's username.
/// </summary>
/// <param name="name">The username of the entity.</param>
public class Flat(string flat) : ValueObject<string>(new FlatValidator(), flat);