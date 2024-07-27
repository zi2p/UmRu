// using Microsoft.AspNetCore.Components.Web;
// using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
// using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
// using BlazorAppUmRu.Client;
//
// var builder = WebAssemblyHostBuilder.CreateDefault(args);
// builder.RootComponents.Add<App>("#app");
// builder.RootComponents.Add<HeadOutlet>("head::after");
//
// builder.Services.AddHttpClient("BlazorAppUmRu.ServerAPI",
//         client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
//     .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
//
// // Supply HttpClient instances that include access tokens when making requests to the server project
// builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorAppUmRu.ServerAPI"));
//
// builder.Services.AddApiAuthorization();
//
// await builder.Build().RunAsync();


using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorAppUmRu;
using BlazorAppUmRu.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
