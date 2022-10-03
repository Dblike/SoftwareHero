namespace SoftwareHero.Core
{
    public struct Employee
    {
        public string Name;
        public string Gender;
        public int Age;
        public EmployeeRole Role;
        
        //Raw Skills
        public Dictionary<CompanyIndustry, Skill> IndustryKnowledge;
        public Skill Skill;

        public override string ToString()
        {
            return $"{Age}{Gender[0]} {Name} Skill: {Skill.Actual}({Skill.Low}-{Skill.High})\n" +
                   $"Knowledge: {string.Join(',', IndustryKnowledge.Where(kvp => kvp.Value.Actual != 0).Select(kvp => $"{kvp.Key}-{kvp.Value.Actual}"))}";
        }
    }
}
