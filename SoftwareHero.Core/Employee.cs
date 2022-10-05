namespace SoftwareHero.Core
{
    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public EmployeeRole Role { get; set; }

        //Raw Skills
        public Dictionary<CompanyIndustry, Skill> IndustryKnowledge { get; set; }
        public Skill Skill { get; set; }

        //Interpersonal
        public List<WorkRelationship> WorkRelationships { get; set; }

        public override string ToString()
        {
            return $"{Age}{Gender[0]} {Name} Skill: {Skill.Actual}({Skill.Low}-{Skill.High})\n" +
                   $"Knowledge: {string.Join(',', IndustryKnowledge.Where(kvp => kvp.Value.Actual != 0).Select(kvp => $"{kvp.Key}-{kvp.Value.Actual}"))}\n" +
                   $"Work Relationships:\n{string.Join("\n", WorkRelationships)}";
        }
    }
}