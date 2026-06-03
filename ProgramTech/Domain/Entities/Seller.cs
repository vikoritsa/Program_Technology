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
    public class Seller : Entity<Guid>
    {
        protected Seller()
        {
        }
        protected Seller(Guid id)
           : base(id) { }

        public void ChangeStatus(Order order, Status newStatus)
        {
            if (order == null) throw new ArgumentNullValueException(nameof(order));
            order.SetStatus(newStatus);
        }
    }
}
