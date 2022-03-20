global using Hyssop.Server.Configurations.Entities;
global using Hyssop.Server.Data;
global using Hyssop.Server.Services.MealTypeService;
global using Hyssop.Server.Services.MenuItemService;
global using Hyssop.Shared;
global using Hyssop.Shared.DTO;
global using Hyssop.Shared.Menu;
global using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<HyssopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HyssopDbConnection"));
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder.Services.AddScoped<IMealTypeService, MealTypeService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
