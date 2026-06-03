using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using Domain.Entities.Base;
using Domain.Entities.Exceptions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class OrderItem : Entity<Guid>
    {
        public Order Order { get; } = default!;
        public Nomination Nomination { get; private set; } = default!;
        public Quantity Quantity { get; private set; } = default!;
        protected OrderItem()
        {
        }
        public OrderItem(
           Order order,
           Nomination nomination,
           Quantity quantity)
           : this(Guid.NewGuid(), order, nomination, quantity) { }

        protected OrderItem(Guid id,
           Order order,
           Nomination nomination,
           Quantity quantity)
           : base(id)
        {
            Order = order ?? throw new ArgumentNullValueException(nameof(order));
            Nomination = nomination ?? throw new ArgumentNullValueException(nameof(nomination));
            Quantity = quantity ?? throw new ArgumentNullValueException(nameof(quantity));
        }

        public void ChangeQuantity(Quantity newQuantity)
        {
            Quantity = newQuantity ?? throw new ArgumentNullValueException(nameof(newQuantity));
        }

        public void ChangeNomination(Nomination newNomination)
        {
            Nomination = newNomination ?? throw new ArgumentNullValueException(nameof(newNomination));
        }

    }
}
