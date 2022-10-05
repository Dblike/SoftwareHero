namespace SoftwareHero.Core
{
    public class WorkRelationship
    {
        public Employee Coworker { get; set; }
        public int TimeWorked { get; set; }
        public int Opinion { get; set; }

        public override string ToString()
        {
            return $"Name: {Coworker.Name}({Coworker.Skill.Actual}) TimeWorked: {TimeWorked} Opinion: {Opinion}";
        }
    }
}
