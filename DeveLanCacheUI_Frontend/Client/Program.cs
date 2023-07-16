using Blazored.LocalStorage;
using DeveLanCacheUI_Frontend;
using DeveLanCacheUI_Frontend.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeveLanCacheUI_Frontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<BackendConnectionService>();

            builder.Services.AddBlazoredLocalStorage();

            await builder.Build().RunAsync();
        }
    }
}