using System;

namespace GuestHouse.Core.Contracts
{
    public interface ILogger
    {
        void Trace(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null);
        void Debug(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null);
        void Info(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null);
        void Warning(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null);
        void Error(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null);
        void Fatal(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null);
    }
}
