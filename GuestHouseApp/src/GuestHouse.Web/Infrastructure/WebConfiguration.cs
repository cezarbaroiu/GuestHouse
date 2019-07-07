using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using GuestHouse.Core.Contracts;
using GuestHouse.Enum;

namespace GuestHouse.Web.Infrastructure
{
    public class WebConfiguration : IConfiguration
    {
        public IList<string> GetStringList(string configurationKey)
        {
            throw new NotImplementedException();
        }

        public IList<Guid> GetGuidList(string configurationKey)
        {
            throw new NotImplementedException();
        }

        public string GetString(string configurationKey)
        {
            return ConfigurationManager.AppSettings[configurationKey];
        }

        public int GetInt(string configurationKey)
        {
            return int.Parse(GetString(configurationKey));
        }

        public bool GetBool(string configurationKey)
        {
            return bool.Parse(GetString(configurationKey));
        }

        public string GetConnectionString(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.Primary:
                    return ConfigurationManager.ConnectionStrings["GuestHouseConnection"].ConnectionString;
                case DatabaseType.Logging:
                    return ConfigurationManager.ConnectionStrings["GuestHouseLogsConnection"].ConnectionString;
                default:
                    throw new Exception();
            }
            
        }
    }
}
