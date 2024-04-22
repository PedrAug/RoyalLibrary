using Microsoft.Extensions.Configuration;


namespace RoyalLibraryFrontEnd.Shared
{
    public class ApiService
    {
        private readonly IConfiguration _configuration;

        public ApiService(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public string GetApiUrl() 
        {
            return _configuration["API_URL"];
        }
    }
}
