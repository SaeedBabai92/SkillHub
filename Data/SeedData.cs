// T�m� luokka varmistaa, ett� tietokanta on migroitu ja alustettu oletusdatalle.
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SkillHub.App.Models;

namespace SkillHub.App.Data
{
    public static class SeedData
    {
        // Varmistaa, ett� tietokanta on olemassa ja alustaa sen
        public static async Task EnsureMigratedAndSeededAsync(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<SkillHubContext>();

            // Suoritetaan mahdolliset migraatiot
            await context.Database.MigrateAsync();

            // Jos taidot puuttuvat, lis�t��n ne
            if (!context.Skills.Any())
            {
                context.Skills.AddRange(
                    new Skill { Name = "C#", Description = "Ohjelmointikieli .NET-ymp�rist��n" },
                    new Skill { Name = "SQL", Description = "Tietokantakieli datan k�sittelyyn" },
                    new Skill { Name = "ASP.NET", Description = "Web-sovellusten kehys .NETiss�" }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}
