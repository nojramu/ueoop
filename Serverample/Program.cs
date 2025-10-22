using Serverample.Components;
using Serverample.Data;
using Serverample.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register Razor Components and interactive server components.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configure the database connection for EF Core (SQLite).
var connectionString = "Data Source=AppData/app.db";
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

// Register the AuthService
builder.Services.AddScoped<AuthService>();

var app = builder.Build();

// Ensure the folder for the SQLite file exists before EF tries to access it.
Directory.CreateDirectory("AppData");

// Create a scope and ensure the database is created (applies migrations / creates file).
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // Use the error handler in non-development environments and enable HSTS.
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days.
    app.UseHsts();

    // Redirect HTTP requests to HTTPS in production-like environments.
    app.UseHttpsRedirection();
}

// Serve static files (wwwroot).
app.UseStaticFiles();

// Add routing middleware.
app.UseRouting();

// Enable antiforgery protection for interactive components.
app.UseAntiforgery();

// Map the root Razor Components app and enable interactive server render mode.
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Start the app.
app.Run();
