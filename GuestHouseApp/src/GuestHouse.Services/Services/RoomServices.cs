using System;
using System.Collections.Generic;
using System.Linq;
using GuestHouse.Core.Dtos.Room;
using GuestHouse.Core.Repository;
using GuestHouse.Core.Services;

namespace GuestHouse.Services.Services
{
    public class RoomServices : IRoomServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<GetRoomDto> GetRooms()
        {
            var rooms = from r in _unitOfWork.RoomRepository.GetRooms()
                select new GetRoomDto()
                {
                    RoomName = r.RoomName,
                    NumberOfPersons = r.NumberOfPersons,
                    PricePerNight = r.PricePerNight,
                    HasOwnBathroom = r.HasOwnBathroom,
                    Description = r.Description
                };
            return rooms.ToList();
        }

        public GetRoomDto GetRoomById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
