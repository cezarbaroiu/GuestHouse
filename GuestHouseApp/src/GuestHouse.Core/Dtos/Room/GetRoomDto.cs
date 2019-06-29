namespace GuestHouse.Core.Dtos.Room
{
    public class GetRoomDto
    {
        public string RoomName { get; set; }
        public int NumberOfPersons { get; set; }
        public decimal PricePerNight { get; set; }
        public bool HasOwnBathroom { get; set; }
        public string Description { get; set; }
    }
}
