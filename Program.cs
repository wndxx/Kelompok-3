using Blazored.SessionStorage;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Programming2.Data;
using Programming2.ModelDB;
using Programming2.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<prog2dbContext>(); 
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<CakeDBService>(); 
builder.Services.AddControllers(); 
builder.Services.AddMudServices();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseEndpoints(e => {e.MapControllers();});
app.Run();
