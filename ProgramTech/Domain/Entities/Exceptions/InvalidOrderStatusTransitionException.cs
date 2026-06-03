using Domain.Enums;

namespace Domain.Entities.Exceptions;

public class InvalidOrderStatusTransitionException(Order order, Status currentStatus, Status newStatus)
    : ArgumentException($"Invalid status transition from {currentStatus} to {newStatus}")
{
    public Order Order => order;
    public Status CurrentStatus => currentStatus;
    public Status NewStatus => newStatus;
}