using System;
using System.Collections.Generic;
using System.Web.Http;
using GuestHouse.Core.Contracts;

namespace GuestHouse.Web.Controllers
{
    public class RoomController : ApiController
    {
        private readonly ILogger _logger;
        public RoomController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<String> GetRooms()
        {
            return new List<String> {"room1", "room2"};
        }
    }
}
