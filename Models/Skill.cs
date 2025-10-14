// This is a placeholder for the Skill model.
// Tämä luokka edustaa yksittäistä taitoa (Skill) järjestelmässä.
namespace SkillHub.App.Models
{
    public class Skill
    {
        public int Id { get; set; }               // Tunniste tietokannassa tai listassa
        public string Name { get; set; }          // Taiton nimi (esim. "C#", "SQL")
        public string Description { get; set; }   // Lyhyt kuvaus taidosta
    }
}
