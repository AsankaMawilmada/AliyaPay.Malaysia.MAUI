namespace AliyaPay.Malaysia.Core.Services
{
    public interface ICurrentUserService
    {
        void SetToken(string token);

        object? GetCurrentUser();

        string? GetCurrentUserRole();

        string? GetFirstName();      
    }
}
