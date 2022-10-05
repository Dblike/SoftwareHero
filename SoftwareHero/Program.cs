using System.Diagnostics;
using SoftwareHero.Core;

var doPrint = false;
var stopwatch = Stopwatch.StartNew();

var rand = new Random(69);
var worldGenerator = new WorldGenerator(rand);
var world = worldGenerator.Generate(new DateOnly(2000, 1, 1), WorldSize.Small);

Print("-----WORLD GENERATION-----");
var worldTime = stopwatch.ElapsedMilliseconds;
Console.WriteLine($"World Generation: {worldTime}ms");
Print(world);

Print("-----INDUSTRIES-----");
var grouped = world.Companies.GroupBy(c => c.Industry).ToList();
foreach (var group in grouped)
{
    Print(group.Key);
    foreach (var company in group)
    {
        Print(company);
    }
    Print();
}

var worldSimulator = new WorldSimulator(rand);
worldSimulator.Initialize(world);

Print("-----SIMULATION RESULTS-----");
var simulationTime = stopwatch.ElapsedMilliseconds - worldTime;
Console.WriteLine($"Simulation: {simulationTime}ms");
Print(world);

void Print(object? output = null)
{
    if (doPrint)
    {
        Console.WriteLine(output);
    }
}