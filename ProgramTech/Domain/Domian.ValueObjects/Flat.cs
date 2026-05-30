using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's flat.
/// </summary>
/// <param name="flat">The flat of the entity.</param>
public class Flat(string flat) : ValueObject<string>(new FlatValidator(), flat);