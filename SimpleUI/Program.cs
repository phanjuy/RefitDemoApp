using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using SimpleUI.DataAccess;

namespace SimpleUI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddRefitClient<IGuestData>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("https://localhost:44345/api");
            });

            await builder.Build().RunAsync();
        }
    }
}
