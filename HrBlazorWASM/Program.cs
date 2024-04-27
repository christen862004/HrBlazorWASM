using HrBlazorWASM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Reflection.Metadata;

namespace HrBlazorWASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            builder.RootComponents.Add<App>("#app");
           
            builder.RootComponents.Add<HeadOutlet>("head::after");//title page base on open component

            builder.Services.AddScoped<EmployeeService>();
            builder.Services.AddScoped<DepartmentService>();
            //register
            
            builder.Services.AddScoped
                (sp => new HttpClient 
                { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
                });

            await builder.Build().RunAsync();
        }
    }
}
