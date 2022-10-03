using BenchmarkDotNet.Running;
using SoftwareHero.Benchmark;

var benchmarks = new[]
{
    typeof(SimulatorBenchmark),
};

foreach (var benchmark in benchmarks)
{
    BenchmarkRunner.Run(benchmark);
}
