// Tämä luokka varmistaa, että tietokanta on migroitu ja alustettu oletusdatalle.
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SkillHub.App.Models;

namespace SkillHub.App.Data
{
    public static class SeedData
    {
        // Varmistaa, että tietokanta on olemassa ja alustaa sen
        public static async Task EnsureMigratedAndSeededAsync(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<SkillHubContext>();

            // Suoritetaan mahdolliset migraatiot
            await context.Database.MigrateAsync();

            // Jos taidot puuttuvat, lisätään ne
            if (!context.Skills.Any())
            {
                context.Skills.AddRange(
                    new Skill { Name = "C#", Description = "Ohjelmointikieli .NET-ympäristöön" },
                    new Skill { Name = "SQL", Description = "Tietokantakieli datan käsittelyyn" },
                    new Skill { Name = "ASP.NET", Description = "Web-sovellusten kehys .NETissä" }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}
