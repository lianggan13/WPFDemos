using System.IO;
using Microsoft.Extensions.Configuration;

namespace SmartParking.Server.Common
{
    public class Configuration : SmartParking.Server.Common.IConfiguration
    {
        private static IConfigurationRoot configurationRoot;

        static Configuration()
        {
            var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json");

            configurationRoot = builder.Build();
        }

        public string Read(string key)
        {
            return configurationRoot[key];
        }
    }
}
