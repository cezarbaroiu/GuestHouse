using System.Data.Entity;

namespace GuestHouse.Repository.Contracts
{
    public interface IConfigurationModule
    {
        void Register(DbModelBuilder modelBuilder);
    }
}
