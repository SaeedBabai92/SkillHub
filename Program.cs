// Perus-usingit palveluille, EF:lle ja Identitylle
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SkillHub.App.Data;
using SkillHub.App.Services;
using SkillHub.App.Services.Interfaces;
using SkillHub.App.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// --- Tietokantayhteys (SQLite) ---
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? "Data Source=skillhub.db";

// Identityn DbContext (käyttäjät ym.)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

// Sovelluksen oma DbContext (Skills, Sessions, …)
builder.Services.AddDbContext<SkillHubContext>(options =>
    options.UseSqlite(connectionString));

// Dev-sivut virheiden tutkimiseen
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// --- ASP.NET Core Identity ---
builder.Services
    .AddDefaultIdentity<IdentityUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false; // DEV: false, PROD: true
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();  // Identity käyttää ApplicationDbContextia

// --- UI-kerros (Razor Pages + Blazor Server) ---
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// --- Sovelluksen palvelut (DI) ---
builder.Services.AddScoped<IExportService, ExportService>();
builder.Services.AddScoped<IRecommendationService, RecommendationService>();


var app = builder.Build();

// --- Middlewaret / pino ---
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint(); // EF dev-sivu
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// --- Reititykset ---
app.MapControllers();
app.MapRazorPages();                   
app.MapFallbackToPage("/_Host");       

// --- Tietokannan migraatiot ja seed ---
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedData.EnsureMigratedAndSeededAsync(services);
}

app.Run();
