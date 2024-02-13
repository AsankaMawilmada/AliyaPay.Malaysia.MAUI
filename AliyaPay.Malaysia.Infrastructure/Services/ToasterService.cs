using AliyaPay.Malaysia.Core.Services;
using CommunityToolkit.Maui.Alerts;

namespace AliyaPay.Malaysia.Infrastructure.Services
{
    public class ToasterService : IToasterService
    {
        public async Task Show(string message)
        {

            await Toast.Make(message).Show();
        }
    }
}
