using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's house.
/// </summary>
/// <param name="house">The house of the entity.</param>
public class House(string house) : ValueObject<string>(new HouseValidator(), house);