using SoftwareHero.Core.Extensions;

namespace SoftwareHero.Core.Factories
{
    public class CompanyFactory
    {
        private static readonly List<CompanyIndustry> CompanyIndustries = Enum.GetValues(typeof(CompanyIndustry)).Cast<CompanyIndustry>().ToList();
        private readonly Random _rand;

        public CompanyFactory(Random rand)
        {
            _rand = rand;
        }

        public Company Make(DateOnly founded, Employee founder, CompanyIndustry industry = CompanyIndustry.Unknown)
        {
            return new Company
            {
                Name = "Dumb Company",
                Description = "Dumb company things",
                Founded = founded,
                Founder = founder,
                Industry = CompanyIndustries.GetRandom(_rand)
            };
        }

        public Company[] MakeMany(DateOnly founded, Employee[] founders)
        {
            return founders.Select(f => Make(founded, f)).ToArray();
        }
    }
}
