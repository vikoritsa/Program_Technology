using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's town.
/// </summary>
/// <param name="town">The town of the entity.</param>
public class Town(string town) : ValueObject<string>(new TownValidator(), town);