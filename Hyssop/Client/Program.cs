global using Hyssop.Shared;
global using Hyssop.Shared.DTO;
global using Hyssop.Shared.Menu;
global using System.Net.Http.Json;

using Hyssop.Client;
using Hyssop.Client.Services.MealTypeService;
using Hyssop.Client.Services.MenuItemService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder.Services.AddScoped<IMealTypeService, MealTypeService>();

await builder.Build().RunAsync();

