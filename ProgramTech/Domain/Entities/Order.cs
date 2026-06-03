using Domain;
using Domain.Entities.Base;
using Domain.Entities.Exceptions;
using Domain.Enums;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Domain.Entities
{
    public class Order : Entity<Guid>
    {
        public Client Client { get; } = default!;
        public Seller Seller { get; } = default!;
        public Adress Adress { get; } = default!;
        public DateTime DeliveryDate { get; private set; } = default!;
        public Wishes? Wishes { get; private set; } = null;
        public Status Status { get; private set; } = Status.New;

        private readonly ICollection<OrderItem> _items = [];
        public IReadOnlyCollection<OrderItem> OrderItems =>
            _items.ToList().AsReadOnly();
        protected Order()
        {
        }
        
        public Order(
            Client client, 
            Seller seller, 
            Adress adress, 
            DateTime deliveryDate, 
            Wishes? wishes = null)
        : this(Guid.NewGuid(), client, seller, adress, deliveryDate, wishes)
        {
        }

        protected Order(Guid id, 
            Client client, 
            Seller seller, 
            Adress adress, 
            DateTime deliveryDate, 
            Wishes? wishes = null)
        : base(id)
        {
            Client = client ?? throw new ArgumentNullValueException(nameof(client));
            Seller = seller ?? throw new ArgumentNullValueException(nameof(seller));
            Adress = adress ?? throw new ArgumentNullValueException(nameof(adress));
            DeliveryDate = deliveryDate;
            Wishes = wishes;
            Status = Status.New;
        }

        public void SetStatus(Status newStatus)
        {
            if (!IsValidTransition(Status, newStatus))
                throw new InvalidOrderStatusTransitionException(this, Status, newStatus);
            Status = newStatus;
        }
        private bool IsValidTransition(Status from, Status to)
        {
            
            return (from, to) switch
            {
                (Status.New, Status.Assembling) => true,
                (Status.New, Status.Cancelled) => true,
                (Status.Assembling, Status.Ready) => true,
                (Status.Ready, Status.Delivering) => true,
                (Status.Delivering, Status.Completed) => true,
                (Status.Delivering, Status.Cancelled) => true,
                _ => false
            };
        }
        public void ChangeDeliveryDate(DateTime newDate)
        {
            if (newDate.Date < DateTime.UtcNow.Date)
                throw new InvalidDeliveryDateException(newDate);
            DeliveryDate = newDate;
        }
        public void AddItem(OrderItem item) { _items.Add(item); }   
    }
}
