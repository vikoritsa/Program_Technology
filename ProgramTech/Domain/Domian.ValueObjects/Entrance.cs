using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's entrance.
/// </summary>
/// <param name="entrance">The entrance of the entity.</param>
public class Entrance(int entrance) : ValueObject<int>(new EntranceValidator(), entrance);
