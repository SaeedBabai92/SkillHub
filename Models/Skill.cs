// This is a placeholder for the Skill model.
// T�m� luokka edustaa yksitt�ist� taitoa (Skill) j�rjestelm�ss�.
namespace SkillHub.App.Models
{
    public class Skill
    {
        public int Id { get; set; }               // Tunniste tietokannassa tai listassa
        public string Name { get; set; }          // Taiton nimi (esim. "C#", "SQL")
        public string Description { get; set; }   // Lyhyt kuvaus taidosta
    }
}
