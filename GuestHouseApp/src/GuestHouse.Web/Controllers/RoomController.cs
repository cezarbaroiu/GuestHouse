using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GuestHouse.Web.Controllers
{
    public class RoomController : ApiController
    {
        [HttpGet]
        public IEnumerable<String> GetRooms()
        {
            return new List<String> {"room1", "room2"};
        }
    }
}
