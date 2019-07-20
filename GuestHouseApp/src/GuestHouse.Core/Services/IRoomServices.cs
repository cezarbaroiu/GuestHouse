using System.Collections.Generic;
using GuestHouse.Core.Dtos.Room;

namespace GuestHouse.Core.Services
{
    public interface IRoomServices
    {
        IList<RoomDto> GetRooms();
        RoomDto GetRoomById(int id);
        
    }
}
