// This is a placeholder for the SkillHubContext class.
using Microsoft.EntityFrameworkCore;
using SkillHub.App.Models;
using SkillHub.App.Pages;

namespace SkillHub.App.Data
{
    public class SkillHubContext : DbContext
    {
        public SkillHubContext(DbContextOptions<SkillHubContext> options)
            : base(options) { }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}


