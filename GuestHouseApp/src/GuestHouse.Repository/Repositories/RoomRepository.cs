using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GuestHouse.Core.Models;
using GuestHouse.Core.Repository;

namespace GuestHouse.Repository.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DbContext _dbContext;

        private readonly DbSet<Room> _roomDbSet;

        public RoomRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _roomDbSet = _dbContext.Set<Room>();
        }
        public IList<Core.Models.Room> GetRooms()
        {
            return _roomDbSet.Include(r => r.Building).ToList();
        }

        public Core.Models.Room GetRoomById(int roomId)
        {
            return _roomDbSet.Find(roomId);
        }
    }
}
