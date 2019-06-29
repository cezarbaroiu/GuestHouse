using System.Collections.Generic;
using GuestHouse.Core.Models;

namespace GuestHouse.Core.Repository
{
    public interface IBuildingRepository
    {
        List<Building> GetBuildings();
        Building GetBuildingById(int id);
    }
}
