namespace GuestHouse.Core.Repository
{
    public interface IUnitOfWork
    {
        IRoomRepository RoomRepository { get; }
        void SaveChanges();
    }
}
