// This is a placeholder for the RecommendationService class.
using SkillHub.App.Models;
using SkillHub.App.Pages;

namespace SkillHub.App.Services
{
    // Interface m‰‰ritt‰‰ suosituspalvelun sopimuksen
    public interface IRecommendationService
    {
        IEnumerable<Skill> RecommendSkills(IEnumerable<Skill> allSkills, string keyword);
    }

    // Toteutus, joka palauttaa suodatettuja suosituksia
    public class RecommendationService : IRecommendationService
    {
        public IEnumerable<Skill> RecommendSkills(IEnumerable<Skill> allSkills, string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return allSkills;

            // Suodattaa taitoja nimen perusteella
            return allSkills
                .Where(s => s.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .Take(5);
        }
    }
}


