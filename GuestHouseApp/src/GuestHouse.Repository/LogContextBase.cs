using System.Data.Entity;
using System.Linq;
using GuestHouse.Repository.Contracts;

namespace GuestHouse.Repository
{
    public class LogContextBase : DbContext
    {
        private readonly IConfigurationModule[] _modules;

        public LogContextBase()
        {
        }

        public LogContextBase(string connection) : base(connection)
        {
        }

        public LogContextBase(string connection, params IConfigurationModule[] modules)
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
