namespace MudBlazorStartUp.Client.Services
{
    public interface IDarkModeService
    {
        public Task SetDarkMode(bool darkMode);

        public Task<bool> GetDarkMode();
    }
}
