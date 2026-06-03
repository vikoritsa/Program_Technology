namespace Domain.Entities.Exceptions
{
    public class InvalidDeliveryDateException(DateTime deliveryDate)
    : ArgumentException($"Invalid delivery date {deliveryDate}, Delivery date cannot be in the past")
    {
        public DateTime DeliveryDate => deliveryDate;
    }
}
