using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;
using UASPemrograman2.ModelDB;
using UASPemrograman2.Service;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddDbContext<projectuasContext>();
builder.Services.AddScoped<FilmDBService>();
builder.Services.AddScoped<TiketService>();
builder.Services.AddScoped<PembeliDBService>();
builder.Services.AddScoped<IFilmService, FilmDBService>();
builder.Services.AddScoped<IPembeliService, PembeliDBService>();


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

app.Run();
