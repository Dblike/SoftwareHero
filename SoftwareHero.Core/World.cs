using System.Text;

namespace SoftwareHero.Core
{
    public class World
    {
        public DateOnly Date { get; set; }
        public List<Company> Companies { get; set; }
        public List<Employee> TalentPool { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach (var company in Companies)
            {
                builder.AppendLine(company.ToString());
            }

            return builder.ToString();
        }
    }
}
