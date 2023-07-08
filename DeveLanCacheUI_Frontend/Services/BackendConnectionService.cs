using Microsoft.JSInterop;

namespace DeveLanCacheUI_Frontend.Services
{
    public class BackendConnectionService
    {
        private readonly IJSRuntime _jSRuntime;

        private string? _backendBaseUrl = null;

        public BackendConnectionService(IJSRuntime jSRuntime)
        {
            _jSRuntime = jSRuntime;
        }

        public async Task<string> GetBackendBaseUrlAsync()
        {
            if (_backendBaseUrl == null)
            {
                _backendBaseUrl = await _jSRuntime.InvokeAsync<string>("eval", "window.ENV.BACKENDURL");
                if (!_backendBaseUrl.EndsWith("/"))
                {
                    _backendBaseUrl += "/";
                }
            }
            return _backendBaseUrl;
        }

        public async Task<string> CreateBackendUrlAsync(string apiPath)
        {
            var backendBaseUrl = await GetBackendBaseUrlAsync();
            return backendBaseUrl + apiPath.TrimStart('/');
        }
    }
}
