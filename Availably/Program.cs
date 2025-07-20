using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
// using Availably.Api.Data;      // your DbContext namespace
// using Availably.Api.Hubs;      // your AvailabilityHub

var builder = WebApplication.CreateBuilder(args);

// 1) (Later) Add EF Core
// builder.Services.AddDbContext<AvailablyDbContext>(opts =>
//     opts.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

// 2) Add controllers (once you scaffold them)
// builder.Services.AddControllers();

// 3) Add SignalR
//builder.Services.AddSignalR();

var app = builder.Build();

// 4) Serve index.html at root and any static files from wwwroot
app.UseDefaultFiles();   // looks for index.html in wwwroot/
app.UseStaticFiles();    // serves js/css/assets from wwwroot/

// 5) Map your hub and controllers
//app.MapHub<AvailabilityHub>("/hubs/availability");
// app.MapControllers();

// 6) (Optional) Fallback to index.html for SPA-like routing
// app.MapFallbackToFile("index.html");

app.Run();