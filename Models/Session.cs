// This is a placeholder for the Session model.
// Tämä luokka edustaa käyttäjän tai istunnon tietoja järjestelmässä.
namespace SkillHub.App.Models
{
    public class Session
    {
        public int Id { get; set; }                 // Istunnon yksilöllinen tunniste
        public string UserName { get; set; }        // Käyttäjän nimi
        public DateTime StartTime { get; set; }     // Milloin istunto alkoi
        public DateTime? EndTime { get; set; }      // Milloin istunto päättyi (voi olla null, jos vielä käynnissä)
        public bool IsActive { get; set; }          // Onko istunto aktiivinen tällä hetkellä
    }
}
