using System;
using System.Collections.Generic;

namespace GuestHouse.Entities
{
    public class Building : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid RoomId { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
