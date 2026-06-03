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
    public class Client(Guid id, Username username, PhoneNumber phoneNumber) : Entity<Guid>(id)
    {
        private readonly ICollection<Order> _orders = [];
        private readonly ICollection<Adress> _adresses = [];

        public Username Username { get; private set; } = username ?? throw new ArgumentNullValueException(nameof(username));

        public PhoneNumber PhoneNumber { get; private set; } = phoneNumber ?? throw new ArgumentNullValueException(nameof(phoneNumber));

        public IReadOnlyCollection<Order> Orders =>
            _orders.ToList().AsReadOnly();
        public IReadOnlyCollection<Adress> Adresses =>
            _adresses.ToList().AsReadOnly();

        public Order CreateOrder(Seller seller, Adress adress, DateTime deliveryDate, Wishes? wishes = null)
        {
            var order = new Order(this, seller, adress, deliveryDate, wishes);
            _orders.Add(order);
            return order;
        }

        public Adress AddAdress(Town town, Street street, House house, Flat? flat = null, Floor? floor = null, Entrance? entrance = null)
        {
            var adress = new Adress(this, town, street, house, flat, floor, entrance);
            _adresses.Add(adress);
            return adress;
        }

    }
}
