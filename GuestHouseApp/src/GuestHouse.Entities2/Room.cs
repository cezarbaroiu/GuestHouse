using System;

namespace GuestHouse.Entities
{
    public class Room : IBaseEntity
    {
        public Guid Id { get; set; }
        public string RoomName { get; set; }
        public int NumberOfPersons { get; set; }
        public decimal PricePerNight { get; set; }
        public bool HasOwnBathroom { get; set; }
        public string Description { get; set; }

        public Guid BuildingId { get; set; }

        public Building Building { get; set; }
    }
}
