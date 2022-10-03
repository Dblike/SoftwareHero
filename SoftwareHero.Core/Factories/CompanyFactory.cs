using SoftwareHero.Core.Extensions;

namespace SoftwareHero.Core.Factories
{
    public class CompanyFactory
    {
        public static readonly List<CompanyIndustry> CompanyIndustries = Enum.GetValues(typeof(CompanyIndustry)).Cast<CompanyIndustry>().ToList();
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
                Industry = founder.IndustryKnowledge.MaxBy(f => f.Value.Actual).Key
            };
        }

        public Company[] MakeMany(DateOnly founded, Employee[] founders)
        {
            return founders.Select(f => Make(founded, f)).ToArray();
        }
    }
}
