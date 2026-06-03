using Domain;
using Domain.Entities.Base;
using Domain.Entities.Exceptions;
using Domain.Enums;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Domain.Entities
{
    public class Adress : Entity<Guid>
    {
        public Client Client { get; } = default!;
        public Town Town { get; } = default!;
        public Street Street { get; } = default!;
        public House House { get; } = default!;
        public Flat? Flat { get; } = null;
        public Floor? Floor { get; } = null;
        public Entrance? Entrance { get; } = null;

        protected Adress()
        {
        }

        public Adress(
           Client client,
           Town town,
           Street street,
           House house,
           Flat? flat = null,
           Floor? floor = null,
           Entrance? entrance =null)
           : this(Guid.NewGuid(), client, town, street, house, flat, floor, entrance) { }

        protected Adress(Guid id,
           Client client,
           Town town,
           Street street,
           House house,
           Flat? flat = null,
           Floor? floor = null,
           Entrance? entrance = null)
           : base(id)
        {
            Client = client ?? throw new ArgumentNullValueException(nameof(client));
            Town = town ?? throw new ArgumentNullValueException(nameof(town));
            Street = street ?? throw new ArgumentNullValueException(nameof(street));
            House = house ?? throw new ArgumentNullValueException(nameof(house));
            Flat = flat;
            Floor = floor;
            Entrance = entrance;
        }
    }
}
