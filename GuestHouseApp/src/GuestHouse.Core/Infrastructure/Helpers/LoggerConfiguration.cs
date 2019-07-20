using System;
using GuestHouse.Core.Contracts;
using GuestHouse.Enum;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace GuestHouse.Core.Infrastructure.Helpers
{
    public class LoggerConfiguration
    {
        private readonly IConfiguration _configuration;

        public LoggerConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;

            var logConnectionString = _configuration.GetConnectionString(DatabaseType.Logging);
            var logCaptureLevel = _configuration.GetString("logLevel");

            if (string.IsNullOrWhiteSpace(logConnectionString) || string.IsNullOrWhiteSpace(logCaptureLevel))
            {
                throw new Exception();
            }

            SetConfiguration(logConnectionString, GetLoggingLevel(logCaptureLevel));
        }

        private void SetConfiguration(string conn, LogLevel logLevel)
        {
            var configuration = new LoggingConfiguration();

            var dbTarget = new DatabaseTarget
            {
                Name = LoggerConstants.TargetName,
                ConnectionString = conn,
                DBProvider = LoggerConstants.DbProvider,
                CommandText = @"INSERT INTO [dbo].[Logs] (Id, TimeStamp, Message, Level, Exception, Logger, AdditionalData, AdditionalIdentifier)
                              VALUES (NEWID(), @timeStamp, @message, @level, @exception, @logger, @additionalData, @additionalIdentifier)",
                Parameters =
                {
                    new DatabaseParameterInfo("@timeStamp", "${date}"),
                    new DatabaseParameterInfo("@message", "${message}"),
                    new DatabaseParameterInfo("@level", "${level}"),
                    new DatabaseParameterInfo("@exception", "${exception}"),
                    new DatabaseParameterInfo("@logger", "${logger}"),
                    new DatabaseParameterInfo("@additionalData", $"${{event-properties:item={LoggerConstants.AdditionalDataPropertyKey}}}"),
                    new DatabaseParameterInfo("@additionalIdentifier", $"${{event-properties:item={LoggerConstants.AdditionalIdPropertyKey}}}")
                }
            };

            configuration.AddTarget(dbTarget);
            configuration.LoggingRules.Add(new LoggingRule("*", logLevel, dbTarget));

            LogManager.Configuration = configuration;
        }

        private LogLevel GetLoggingLevel(string logLevel)
        {
            switch (logLevel)
            {
                case "Trace":
                    return LogLevel.Trace;
                case "Debug":
                    return LogLevel.Debug;
                case "Info":
                    return LogLevel.Info;
                case "Warn":
                    return LogLevel.Warn;
                case "Error":
                    return LogLevel.Error;
                case "Fatal":
                    return LogLevel.Fatal;
                case "Off":
                    return LogLevel.Off;
                default:
                    throw new Exception();
            }
        }
    }
}
