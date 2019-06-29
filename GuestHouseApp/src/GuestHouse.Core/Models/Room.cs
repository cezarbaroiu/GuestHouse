using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHouse.Core.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int NumberOfPersons { get; set; }
        public decimal PricePerNight { get; set; }
        public bool HasOwnBathroom { get; set; }
        public string Description { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }
    }
}
