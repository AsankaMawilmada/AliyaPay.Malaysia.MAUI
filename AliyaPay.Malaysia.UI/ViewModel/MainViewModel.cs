using AliyaPay.Malaysia.Core.Services;
using AliyaPay.Malaysia.UI.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace AliyaPay.Malaysia.UI.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        string emailAddress = "";

        [ObservableProperty]
        string password = "";

        private readonly IAuthenticationService _authenticationService;
        private readonly IToasterService _toasterService;
        public MainViewModel(IAuthenticationService authenticationService, IToasterService toasterService)
        {
            _authenticationService = authenticationService;
            _toasterService = toasterService;
        }

        [RelayCommand]
        async Task Login()
        {
            if (string.IsNullOrWhiteSpace(EmailAddress) || string.IsNullOrWhiteSpace(Password))
                return;

            IsRunning = true;

            var authenticated = await _authenticationService.Authenticate(EmailAddress, Password);

            IsRunning = false;

            if (!authenticated)
            {
                await _toasterService.Show("Please check your email address and password.");
                return;
            }

            await Shell.Current.GoToAsync(nameof(DashboardPage));
        }
    }
}
