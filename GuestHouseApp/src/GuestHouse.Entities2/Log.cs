using System;
using System.Runtime.Remoting.Activation;

namespace GuestHouse.Entities
{
    public class Log : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public string Exception { get; set; }
        public string Logger { get; set; }
        public string AdditionalData { get; set; }
    }
}
