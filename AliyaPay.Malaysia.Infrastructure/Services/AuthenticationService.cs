using AliyaPay.Malaysia.Core.Responses;
using AliyaPay.Malaysia.Core.Services;
using RestSharp;

namespace AliyaPay.Malaysia.Infrastructure.Services
{
    public class AuthenticationService : BaseAPIService, IAuthenticationService
    {      
        private readonly ICurrentUserService _currentUserService;
        public AuthenticationService(IConfigurationService configurationService, ICurrentUserService currentUserService) : base(configurationService)
        {
            _currentUserService = currentUserService;
        }

        public async Task<bool> Authenticate(string emailAddress, string password)
        {           
            RestRequest Request = new RestRequest("authentication/sign-in", Method.Post);
            Request.RequestFormat = DataFormat.Json;
            Request.AddJsonBody(new { email = emailAddress, password = password });
            Request.AddHeader("Content-Type", "application/json");

            RestClient client = new RestClient(_baseUrl);            
            var response = await client.ExecuteAsync<AuthenticationResponse>(Request);

            if (response.IsSuccessStatusCode)
            {
                _currentUserService.SetToken(response.Data.Token);

                return true;
            }


            return false;
        }
    }
}
