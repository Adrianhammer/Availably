using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Availably.Data;

var builder = WebApplication.CreateBuilder(args);

//gets secrets
builder.Configuration.AddUserSecrets<Program>();

// adds EF Core (database)
//builder.Services.AddDbContext<AvailablyDbContext>(opts => 
//    opts.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

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

app.Run();