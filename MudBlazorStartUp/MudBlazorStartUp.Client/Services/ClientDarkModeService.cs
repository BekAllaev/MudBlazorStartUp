
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

namespace MudBlazorStartUp.Client.Services
{
    public class ClientDarkModeService : IDarkModeService
    {
        private readonly HttpClient _httpClient;

        public ClientDarkModeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<bool> GetDarkMode()
        {
            return _httpClient.GetFromJsonAsync<bool>("api/darkMode");
        }

        public Task SetDarkMode(bool darkMode)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    isDarkMode = darkMode
                }),
                Encoding.UTF8,
                "application/json");

            return _httpClient.PostAsync("api/darkMode", jsonContent);
        }
    }
}
