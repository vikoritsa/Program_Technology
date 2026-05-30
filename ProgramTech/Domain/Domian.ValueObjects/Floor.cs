using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's floor.
/// </summary>
/// <param name="floor">The floor of the entity.</param>
public class Floor(int floor) : ValueObject<int>(new FloorValidator(), floor);
