using System;
using System.Collections.Generic;
using GuestHouse.Core.Dtos.Room;
using GuestHouse.Core.Repository;
using GuestHouse.Core.Services;

namespace GuestHouse.Services.Services
{
    public class RoomServices : IRoomServices
    {

        public RoomServices()
        {
        }

        public IList<RoomDto> GetRooms()
        {
            return null;
        }

        public RoomDto GetRoomById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
