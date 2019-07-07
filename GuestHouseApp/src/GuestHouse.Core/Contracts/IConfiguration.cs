using System;
using System.Collections.Generic;
using GuestHouse.Enum;

namespace GuestHouse.Core.Contracts
{
    public interface IConfiguration
    {
        IList<string> GetStringList(string configurationKey);
        IList<Guid> GetGuidList(string configurationKey);
        string GetString(string configurationKey);
        int GetInt(string configurationKey);
        bool GetBool(string configurationKey);
        string GetConnectionString(DatabaseType type);

    }
}
