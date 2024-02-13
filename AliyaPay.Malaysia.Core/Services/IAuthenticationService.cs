
namespace AliyaPay.Malaysia.Core.Services
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string emailAddress, string password);
    }
}
