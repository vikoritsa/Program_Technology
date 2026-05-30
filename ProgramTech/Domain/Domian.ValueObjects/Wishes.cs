using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's wishes.
/// </summary>
/// <param name="wishes">The wishes of the entity.</param>
public class Wishes(string wishes) : ValueObject<string>(new WishesValidator(), wishes);