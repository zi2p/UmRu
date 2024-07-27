using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp1.Client;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Укажите базовый адрес вашего сервера
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7007/") });

await builder.Build().RunAsync();