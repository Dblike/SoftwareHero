namespace SoftwareHero.Core
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<EngineeringArea, int> Quality { get; set; }
    }
}
