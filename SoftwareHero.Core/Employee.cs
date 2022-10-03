namespace SoftwareHero.Core
{
    public struct Employee
    {
        public string Name;
        public string Gender;
        public int Age;
        public EmployeeRole Role;
        
        //Raw Skills
        public Skill Skill;

        public override string ToString()
        {
            return $"{Age}{Gender[0]} {Name} Skill: {Skill.Actual}({Skill.Low}-{Skill.High})";
        }
    }
}
