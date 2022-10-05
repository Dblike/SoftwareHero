namespace SoftwareHero.Core
{
    public class WorldSimulator
    {
        private const int MinNumEmployeesToHire = 1;
        private const int MaxNumEmployeesToHire = 4;
        private readonly Random _rand;

        public WorldSimulator(Random rand)
        {
            _rand = rand;
        }

        public void Initialize(World world)
        {
            // Step 1: Each company hires employees
            foreach (var company in world.Companies)
            {
                // Step 1a: Interview candidates from talent pool
                var hired = Interview(company, world.TalentPool, _rand.Next(MinNumEmployeesToHire, MaxNumEmployeesToHire));
                foreach (var hire in hired)
                {
                    company.Employees.Add(hire);
                    world.TalentPool.Remove(hire);
                }
                
                // Step 1b: Add work relationships
                for (var employeeIdx = 0; employeeIdx < company.Employees.Count; employeeIdx++)
                {
                    var employee = company.Employees[employeeIdx];
                    for (var addIdx = 0; addIdx < company.Employees.Count; addIdx++)
                    {
                        if (employeeIdx == addIdx) continue;
                        var coworker = company.Employees[addIdx];
                        employee.WorkRelationships.Add(new WorkRelationship
                        {
                            Coworker = coworker,
                            TimeWorked = 0,
                            Opinion = CalculateInitialOpinion(employee, coworker)
                        });
                    }
                }
            }
        }

        public void Simulate(World world)
        {
            // Step 1: Each company determines project
            foreach (var company in world.Companies)
            {
                
            }
            // Step 2: Tasks are generated for the project
            // Step 3: Tasks are worked on for the project
            // Step 4: Relationships are updated
            // Step 5: Completed tasks update project quality
            // Step 6: Quality determines if bugs have emerged
        }

        private static int CalculateInitialOpinion(Employee employee, Employee coworker)
        {
            //TODO: Determine factors that go into initial opinion
            return 0;
        }

        //TODO: Optimize this turd sandwich
        private static IEnumerable<Employee> Interview(Company company, IEnumerable<Employee> hiringPool, int numEmployeesToHire)
        {
            // For now, assume founders will hire most talented person with knowledge of industry
            return hiringPool
                .Where(e => e.IndustryKnowledge.MaxBy(pair => pair.Value.Actual).Key == company.Industry)
                .OrderBy(e => e.Skill.Actual)
                .Take(numEmployeesToHire);
        }
    }
}
