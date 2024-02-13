using AliyaPay.Malaysia.Core.Services;

namespace AliyaPay.Malaysia.Infrastructure.Services
{
    public class BaseAPIService
    {
        public string _baseUrl { get; set; }
        public BaseAPIService(IConfigurationService configurationService)
        {
            _baseUrl = configurationService.APIBaseUrl();
        }
    }
}
