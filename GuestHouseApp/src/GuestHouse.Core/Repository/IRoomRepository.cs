using System.Collections.Generic;
using GuestHouse.Core.Models;

namespace GuestHouse.Core.Repository
{
    public interface IRoomRepository
    {
        IList<Room> GetRooms();

        Room GetRoomById(int id);
    }
}
