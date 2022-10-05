namespace SoftwareHero.Core
{
    public class Company
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly Founded { get; set; }
        public Employee Founder { get; set; }
        public CompanyIndustry Industry { get; set; }
        public List<Employee> Employees { get; set; }
        public Product Product { get; set; }

        public override string ToString()
        {
            return $"({Industry} - {Founded}) {Name} - {Description}\nFounder: {Founder}\n";
        }
    }
}
