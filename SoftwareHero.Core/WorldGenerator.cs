using SoftwareHero.Core.Factories;

namespace SoftwareHero.Core
{
    public class WorldGenerator
    {
        // Deterministic World Generation
        private readonly Random _rand;

        public WorldGenerator(Random rand)
        {
            _rand = rand;
        }

        public World Generate(DateOnly startDate, WorldSize worldSize)
        {
            var employeeFactory = new EmployeeFactory(_rand);
            var companyFactory = new CompanyFactory(_rand);
            var (numFounders, talentPoolSize) = GetWorldDimensions(worldSize);

            // Step 1: Generate Founders
            var founders = employeeFactory.MakeMany(numFounders, EmployeeRole.Founder);

            // Step 2: Found Companies
            var companies = companyFactory.MakeMany(startDate, founders);

            // Step 3: Generate talent pool
            var talentPool = employeeFactory.MakeMany(talentPoolSize);

            return new World
            {
                Date = startDate,
                Companies = companies.ToList(),
                TalentPool = talentPool.ToList()
            };
        }

        private static (int NumFounders, int TalentPoolSize) GetWorldDimensions(WorldSize worldSize)
        {
            switch (worldSize)
            {
                case WorldSize.Small:
                    return (10, 100);
                case WorldSize.Medium:
                    return (50, 1000);
                case WorldSize.Large:
                    return (100, 10000);
                case WorldSize.ExtraLarge:
                    return (200, 100000);
                case WorldSize.Custom: 
                default:
                    throw new ArgumentOutOfRangeException(nameof(worldSize), worldSize, null);
            }
        }
    }
}
