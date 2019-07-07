using System;
using GuestHouse.Core.Infrastructure.Helpers;
using NLog;
using ILogger = GuestHouse.Core.Contracts.ILogger;

namespace GuestHouse.Core.Infrastructure
{
    public class Logger : ILogger
    {
        private NLog.ILogger _logger;

        public Logger(Type type)
        {
            _logger = LogManager.GetLogger(type.FullName);
        }

        public void Trace(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null)
        {
            LogMessage(message, LogLevel.Trace, exception, additionalIdentifier, additionalData);
        }

        public void Debug(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null)
        {
            LogMessage(message, LogLevel.Debug, exception, additionalIdentifier, additionalData);
        }

        public void Info(string message, Exception exception = null, string additionalIdentifier = null, string additionalData = null)
        {
            LogMessage(message, LogLevel.Info, exception, additionalIdentifier, additionalData);
        }

        public void Warning(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null)
        {
            LogMessage(message, LogLevel.Warn, exception, additionalIdentifier, additionalData);
        }

        public void Error(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null)
        {
            LogMessage(message, LogLevel.Error, exception, additionalIdentifier, additionalData);
        }

        public void Fatal(string message, Exception exception = null, string additionalIdentifier = null,
            string additionalData = null)
        {
            LogMessage(message, LogLevel.Fatal, exception, additionalIdentifier, additionalData);
        }

        private void LogMessage(string message, LogLevel logLevel, Exception exception, string additionalIdentifier, string additionalData)
        {
            var eventInfo = new LogEventInfo(logLevel, _logger.Name, message)
            {
                Exception = exception
            };

            eventInfo.Properties[LoggerConstants.AdditionalIdPropertyKey] = additionalIdentifier;
            eventInfo.Properties[LoggerConstants.AdditionalDataPropertyKey] = additionalData;

            _logger.Log(typeof(Logger), eventInfo);
        }
    }
}
