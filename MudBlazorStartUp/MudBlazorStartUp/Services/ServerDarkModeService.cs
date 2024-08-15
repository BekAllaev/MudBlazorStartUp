using MudBlazorStartUp.Client.Services;
using MudBlazorStartUp.State;

namespace MudBlazorStartUp.Services
{
    public class ServerDarkModeService : IDarkModeService
    {
        public async Task<bool> GetDarkMode()
        {
            await Task.CompletedTask;

            return DarkModeState.GetIsDarkMode();
        }

        public async Task SetDarkMode(bool darkMode)
        {
            await Task.CompletedTask;

            DarkModeState.SetIsDarkMode(darkMode);
        }
    }
}
