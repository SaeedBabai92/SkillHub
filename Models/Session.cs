// This is a placeholder for the Session model.
// T�m� luokka edustaa k�ytt�j�n tai istunnon tietoja j�rjestelm�ss�.
namespace SkillHub.App.Models
{
    public class Session
    {
        public int Id { get; set; }                 // Istunnon yksil�llinen tunniste
        public string UserName { get; set; }        // K�ytt�j�n nimi
        public DateTime StartTime { get; set; }     // Milloin istunto alkoi
        public DateTime? EndTime { get; set; }      // Milloin istunto p��ttyi (voi olla null, jos viel� k�ynniss�)
        public bool IsActive { get; set; }          // Onko istunto aktiivinen t�ll� hetkell�
    }
}
