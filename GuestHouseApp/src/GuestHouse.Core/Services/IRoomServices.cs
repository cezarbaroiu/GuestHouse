using System.Collections.Generic;
using GuestHouse.Core.Dtos.Room;

namespace GuestHouse.Core.Services
{
    public interface IRoomServices
    {
        IList<GetRoomDto> GetRooms();
        GetRoomDto GetRoomById(int id);
    }
}
