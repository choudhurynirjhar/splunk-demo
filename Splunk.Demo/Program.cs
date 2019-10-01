using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Splunk.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ContainerConfiguration.Configure();

            var logger = serviceProvider.GetService<ILogger<Program>>();
            logger.LogInformation($"Test splunk log {DateTime.Now}");
        }
    }
}
