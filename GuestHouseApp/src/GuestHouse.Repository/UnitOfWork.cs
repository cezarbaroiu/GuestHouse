using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestHouse.Core.Repository;

namespace GuestHouse.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        public IRoomRepository RoomRepository { get; private set; }

        public UnitOfWork(DbContext dbContext, IRoomRepository roomRepository)
        {
            _dbContext = dbContext;
            RoomRepository = roomRepository;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
