using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using SoftwareHero.Core;

namespace SoftwareHero.Benchmark
{
    [SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    [MemoryDiagnoser]
    public class SimulatorBenchmark
    {
        private WorldGenerator _worldGenerator;

        //[Params(WorldSize.Small, WorldSize.Medium, WorldSize.Large, WorldSize.ExtraLarge)]
        //public WorldSize WorldSize { get; set; }

        [Params(WorldSize.ExtraLarge)]
        public WorldSize WorldSize { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _worldGenerator = new WorldGenerator(new Random(1));
        }

        [Benchmark]
        public World GenerateWorld()
        {
            return _worldGenerator.Generate(new DateOnly(2000, 1, 1), WorldSize);
        }
    }
}
