using BenchmarkDotNet.Running;
using AegisSim.Benchmarks;

BenchmarkRunner.Run<SimulationBenchmarks>();
BenchmarkRunner.Run<SpatialHashBenchmarks>();