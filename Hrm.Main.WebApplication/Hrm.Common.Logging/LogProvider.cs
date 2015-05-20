#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project:  HRM
// Module : Common.Logging
// Author : Niluksha W, Virtusa
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.Logging
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Diagnostics;
    using log4net;
    using log4net.Core;
    using log4net.Appender;
    using System.IO;

    /// <summary>
    /// Define accepted logging levels
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Debug log level
        /// </summary>
        Debug,

        /// <summary>
        /// Information log level
        /// </summary>
        Info,

        /// <summary>
        /// Warning log level
        /// </summary>
        Warning,

        /// <summary>
        /// Error log level
        /// </summary>
        Error
    }

    /// <summary>
    /// Provide and manage logging related functionality
    /// </summary>
    [DebuggerNonUserCode]
    public static class LogProvider
    {
        /// <summary>
        /// Keeps a list of created logger objects
        /// </summary>
        private static Hashtable loggers = new Hashtable();

        /// <summary>
        /// customized logging format
        /// </summary>
        private const string customLogFormat = "{0} | User Id: {1}\n";

        /// <summary>
        /// The empty unique value
        /// </summary>
        private const string EmptyUniqueValue = "";

        /// <summary>
        /// Initializes static members of the LogProvider class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
        static LogProvider()
        {
            //Configure logging using xmlConfiguration information provided
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        /// Enables the process wise logging.
        /// </summary>
        /// <param name="isEnabled">if set to <c>true</c> [is enabled].</param>
        public static void EnableProcessWiseLogging(bool isEnabled, string uniqueKey = EmptyUniqueValue)
        {
            if (isEnabled)
            {
                // Get the list of configured appenders
                var fileAppenders = from appender in LogManager.GetRepository().GetAppenders()
                                    where appender is FileAppender
                                    select appender;

                // Modify the log file name of each appender
                fileAppenders.Cast<FileAppender>()
                    .ToList().ForEach(
                        fa =>
                        {
                            // Build the subfolder name from process id and a unique value provided as parameter (normally this will be job no).
                            string uniqueSubFolderName = null;
                            if (string.IsNullOrWhiteSpace(uniqueKey))
                            {
                                uniqueSubFolderName = string.Format("PID_{0}", Process.GetCurrentProcess().Id.ToString());
                            }
                            else
                            {
                                uniqueSubFolderName = string.Format("PID_{0}_{1}", Process.GetCurrentProcess().Id.ToString(), uniqueKey);
                            }

                            // Create a sub folder for each separate process
                            string folderPath = Path.GetDirectoryName(fa.File.ToString());
                            string newFilePath = Path.Combine(folderPath, uniqueSubFolderName, Path.GetFileName(fa.File));

                            if (!string.IsNullOrWhiteSpace(newFilePath))
                            {
                                fa.File = newFilePath;
                                fa.ActivateOptions();
                            }
                        }
                ); 
            }
        }

        /// <summary>
        /// This will Log the provided logging information to a log file. 
        /// </summary>
        /// <param name="callerType"> Used to indicate caller type.</param>
        /// <param name="logLevel"> Used to indicate log level.</param>
        /// <param name="message"> Used to pass the logging message.</param>
        public static void Log(Type callerType, LogLevel logLevel, string message)
        {
            if (null == callerType)
            {
                throw new ArgumentNullException("callerType", "calling Log() method with null callerType is not allowed");
            }

            //Get the correct logger instance
            Log4NetLogger logger = GetLogger(logLevel.ToString());

            //Log the logging information provided
            logger.Log(callerType, ConvertLogLevel(logLevel), message);

        }

        /// <summary>
        /// This will Log the provided logging information to a log file. 
        /// </summary>
        /// <param name="callerType"> Used to indicate caller type.</param>
        /// <param name="logLevel"> Used to indicate log level.</param>
        /// <param name="message"> Used to pass the logging message.</param>
        /// <param name="ex"> Used to pass the exception object.</param>
        public static void Log(Type callerType, LogLevel logLevel, string message, Exception ex)
        {
            if (null == callerType)
            {
                throw new ArgumentNullException("callerType", "calling Log() method with null callerType is not allowed");
            }

            //Get the correct logger instance
            Log4NetLogger logger = GetLogger(logLevel.ToString());

            //Log the logging information provided
            logger.Log(callerType, ConvertLogLevel(logLevel), message, ex);
        }

        /// <summary>
        /// This will Log the provided logging information to a log file. 
        /// </summary>
        /// <param name="callerType"> Used to indicate caller type.</param>
        /// <param name="logLevel"> Used to indicate log level.</param>
        /// <param name="message"> Used to pass the logging message.</param>
        public static void Log(Type callerType, LogLevel logLevel, string message, string userId)
        {
            if (null == callerType)
            {
                throw new ArgumentNullException("callerType", "calling Log() method with null callerType is not allowed");
            }

            //Get the correct logger instance
            Log4NetLogger logger = GetLogger(logLevel.ToString());

            //Log the logging information provided
            logger.Log(callerType, ConvertLogLevel(logLevel), string.Format(customLogFormat, message, userId));

        }

        /// <summary>
        /// This will Log the provided logging information to a log file. 
        /// </summary>
        /// <param name="callerType"> Used to indicate caller type.</param>
        /// <param name="logLevel"> Used to indicate log level.</param>
        /// <param name="message"> Used to pass the logging message.</param>
        /// <param name="ex"> Used to pass the exception object.</param>
        public static void Log(Type callerType, LogLevel logLevel, string message, Exception ex, string userId)
        {
            if (null == callerType)
            {
                throw new ArgumentNullException("callerType", "calling Log() method with null callerType is not allowed");
            }

            //Get the correct logger instance
            Log4NetLogger logger = GetLogger(logLevel.ToString());

            //Log the logging information provided
            logger.Log(callerType, ConvertLogLevel(logLevel), string.Format(customLogFormat, message, userId), ex);
        }

        /// <summary>
        /// Returns the correct logger instance 
        /// </summary>
        /// <param name="loggerName"> Used to indicate the logger name.</param>
        /// <returns> Returns the logger instance.</returns>
        private static Log4NetLogger GetLogger(string loggerName)
        {
            Log4NetLogger returnLogger = null;

            if (!loggers.ContainsKey(loggerName))
            {
                lock (loggers)
                {
                    if (!loggers.ContainsKey(loggerName))
                    {
                        //New logger. Create an instance of the logger and add to list
                        returnLogger = new Log4NetLogger(log4net.LogManager.GetLogger(loggerName));
                        loggers.Add(loggerName, returnLogger);
                    }
                }
            }

            returnLogger = (Log4NetLogger)loggers[loggerName];

            if (null == returnLogger)
            {
                throw new LogException("could not obtain a logger from log4net framework");
            }

            return returnLogger;
        }

        /// <summary>
        /// Returns the corresponding Log4Net log level 
        /// </summary>
        /// <param name="level"> Used to indicate the log level.</param>
        /// <returns> Returns the corresponding Log4Net log level.</returns>
        private static Level ConvertLogLevel(LogLevel level)
        {
            Level returnLevel = null;
            switch (level)
            {
                case LogLevel.Debug:
                    returnLevel = Level.Debug;
                    break;
                case LogLevel.Warning:
                    returnLevel = Level.Warn;
                    break;
                case LogLevel.Error:
                    returnLevel = Level.Error;
                    break;
                case LogLevel.Info:
                default:
                    returnLevel = Level.Info;
                    break;
            }

            return returnLevel;
        }

    }
}
