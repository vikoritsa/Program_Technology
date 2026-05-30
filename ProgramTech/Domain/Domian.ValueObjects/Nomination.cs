using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

/// <summary>
/// Represents type of the entity's nomination.
/// </summary>
/// <param name="nomination">The nomination of the entity.</param>
public class Nomination(string nomination) : ValueObject<string>(new NominationValidator(), nomination);