using System;
using System.Collections.Generic;
using System.Linq;
using GuestHouse.Entities;

namespace GuestHouse.Repository
{
    public class DbSeed
    {
        private static readonly Guid building1Id = Guid.Parse("D03C1CDB-3820-474C-9738-76E42CFF2C14");
        private static readonly Guid building2Id = Guid.Parse("CF789C74-B9F2-4BB2-A8A7-86B7A854E39E");
        private static readonly Guid building3Id = Guid.Parse("B95BFB33-945A-4DEF-A408-A3C7F8D5AC8C");

        internal static void PopulateDatabase(DatabaseContext context)
        {

            var buildingList = BuildBuildingsList();
            if (context.Building.Count() != buildingList.Count)
            {
                context.Building.RemoveRange(context.Building);
                context.Building.AddRange(buildingList);
            }

            var roomList = BuildRoomsList();
            if (context.Room.Count() != roomList.Count)
            {
                context.Room.RemoveRange(context.Room);
                context.Room.AddRange(roomList);
            }

            context.SaveChanges();
        }

        private static List<Building> BuildBuildingsList()
        {
            return new List<Building>
            {
                new Building
                {
                    Id = building1Id,
                    Name = "Building1",
                    Description = "This is building 1",
                },
                new Building
                {
                    Id = building2Id,
                    Name = "Building2",
                    Description = "This is building 2",
                },
                new Building
                {
                    Id = building3Id,
                    Name = "Building3",
                    Description = "This is building 3",
                },
            };
        }

        private static List<Room> BuildRoomsList()
        {
            return new List<Room>
            {
                new Room
                {
                    Id = Guid.NewGuid(),
                    BuildingId = building1Id,
                    Description = "This is Room1",
                    HasOwnBathroom = true,
                    NumberOfPersons = 2,
                    RoomName = "Room1",
                    PricePerNight = 100.0M
                },
                new Room
                {
                    Id = Guid.NewGuid(),
                    BuildingId = building2Id,
                    Description = "This is Room2",
                    HasOwnBathroom = true,
                    NumberOfPersons = 3,
                    RoomName = "Room2",
                    PricePerNight = 120.0M
                },
                new Room
                {
                    Id = Guid.NewGuid(),
                    BuildingId = building3Id,
                    Description = "This is Room3",
                    HasOwnBathroom = true,
                    NumberOfPersons = 4,
                    RoomName = "Room3",
                    PricePerNight = 200.0M
                },
                new Room
                {
                    Id = Guid.NewGuid(),
                    BuildingId = building3Id,
                    Description = "This is Room4",
                    HasOwnBathroom = true,
                    NumberOfPersons = 1,
                    RoomName = "Room4",
                    PricePerNight = 90.0M
                }
            };
        }
    }
}
