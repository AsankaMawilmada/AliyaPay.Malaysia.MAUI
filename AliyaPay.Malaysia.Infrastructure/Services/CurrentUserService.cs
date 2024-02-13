using AliyaPay.Malaysia.Core.Configuration;
using AliyaPay.Malaysia.Core.Services;
using Microsoft.Extensions.Configuration;

namespace AliyaPay.Malaysia.Infrastructure.Services
{

    public class CurrentUserService : ICurrentUserService
    {
        public string? _token { get; set; }

        public object? GetCurrentUser()
        {
            if (_token == null)
                return null;

            return "";
        }

        public string? GetCurrentUserRole()
        {
            if (_token == null)
                return null;

            return "";
        }

        public string? GetFirstName()
        {
            if (_token == null)
                return null;

            return "";
        }

        public void SetToken(string token)
        {
            _token = token;
        }
    }
}
