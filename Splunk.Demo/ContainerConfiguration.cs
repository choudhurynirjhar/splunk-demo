using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using System;


namespace Splunk.Demo
{
    internal static class ContainerConfiguration
    {
        public static IServiceProvider Configure()
        {
            var serviceCollection = new ServiceCollection();

            LogManager.LoadConfiguration("nlog.xml");

            serviceCollection.AddLogging(l => 
            {
                l.AddNLog();
            }).Configure<LoggerFilterOptions>(c => c.MinLevel = Microsoft.Extensions.Logging.LogLevel.Trace);

            return serviceCollection.BuildServiceProvider();
        }
    }
}
