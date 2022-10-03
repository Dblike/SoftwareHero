using SoftwareHero.Core;

var worldGenerator = new WorldGenerator(69);
var world = worldGenerator.Generate(new DateOnly(2000, 1, 1), WorldSize.Small);

Console.WriteLine(world);
var grouped = world.Companies.GroupBy(c => c.Industry).ToList();
foreach (var group in grouped)
{
    Console.WriteLine(group.Key);
    foreach (var company in group)
    {
        Console.WriteLine(company);
    }
    Console.WriteLine();
}