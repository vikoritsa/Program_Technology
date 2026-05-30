using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's quantity.
/// </summary>
/// <param name="quantity">The quantity of the entity.</param>
public class Quantity(int quantity) : ValueObject<int>(new QuantityValidator(), quantity);