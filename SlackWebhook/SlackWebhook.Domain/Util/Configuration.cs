using System.IO;
using Microsoft.Extensions.Configuration;

namespace SlackWebhook.Domain.Util
{
    public class Configuration
    {
        static public string DbConnectionString()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            var connectionStringConfig = builder.Build();

            return connectionStringConfig.GetConnectionString("DefaultConnection");
        }
    }
}
