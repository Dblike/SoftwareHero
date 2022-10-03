namespace SoftwareHero.Core
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<EngineeringTask> EngineeringTasks { get; set; }
    }
}
