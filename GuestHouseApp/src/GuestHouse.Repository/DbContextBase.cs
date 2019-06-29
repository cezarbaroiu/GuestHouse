using System.Data.Entity;
using System.Linq;
using GuestHouse.Repository.Contracts;

namespace GuestHouse.Repository
{
    public class DbContextBase : DbContext
    {
        private readonly IConfigurationModule[] _modules;
       protected DbContextBase() { }

       protected DbContextBase(string connectionString) : base(connectionString)
       {
       }

       protected DbContextBase(string connection, params IConfigurationModule[] modules) : base(connection)
       {
           _modules = modules;
       }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           base.OnModelCreating(modelBuilder);
           if (_modules != null && _modules.Any())
           {
               foreach (var module in _modules)
               {
                   module.Register(modelBuilder);
               }
           }
       }
    }
}
