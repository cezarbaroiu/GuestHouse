using System.Data.Entity;

namespace GuestHouse.Core.Contracts
{
    public interface IConfigurationModule
    {
        void Register(DbModelBuilder modelBuilder);
    }
}
