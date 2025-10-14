// This is a placeholder for the ExportService class.
namespace SkillHub.App.Services
{
    // Interface m‰‰ritt‰‰ sopimuksen vientipalvelulle
    public interface IExportService
    {
        string ExportToCsv<T>(IEnumerable<T> data);
    }

    // Toteutusluokka, joka suorittaa varsinaisen viennin
    public class ExportService : IExportService
    {
        public string ExportToCsv<T>(IEnumerable<T> data)
        {
            if (data == null || !data.Any())
                return string.Empty;

            var properties = typeof(T).GetProperties();
            var lines = new List<string>();

            // Otsikkorivi
            lines.Add(string.Join(",", properties.Select(p => p.Name)));

            // Data
            foreach (var item in data)
            {
                var values = properties.Select(p => p.GetValue(item, null)?.ToString()?.Replace(",", ";"));
                lines.Add(string.Join(",", values));
            }

            // Palauttaa CSV-muotoisen tekstin
            return string.Join(Environment.NewLine, lines);
        }
    }
}


