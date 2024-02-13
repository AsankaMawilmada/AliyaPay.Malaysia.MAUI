using AliyaPay.Malaysia.Core.Configuration;
using AliyaPay.Malaysia.Core.Services;
using Microsoft.Extensions.Configuration;

namespace AliyaPay.Malaysia.Infrastructure.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration _configuration;
        public ConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string APIBaseUrl()
        {
            return _configuration.GetRequiredSection("Settings").GetSection("APIBaseUrl").Value;
        }
    }
}
