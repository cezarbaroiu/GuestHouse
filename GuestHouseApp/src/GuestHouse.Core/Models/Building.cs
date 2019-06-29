using System.Collections.Generic;

namespace GuestHouse.Core.Models
{
    public class Building
    {
        public int BuildingId { get; set; }
        public int RoomId { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
