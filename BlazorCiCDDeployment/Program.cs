
using MachineParkAlpha.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCiCDDeployment
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://machinefuncapi20211107093917.azurewebsites.net")
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7071/")
            });
            builder.Services.AddSingleton<IMachineList, MachineList>();

            await builder.Build().RunAsync();
        }
    }
}
