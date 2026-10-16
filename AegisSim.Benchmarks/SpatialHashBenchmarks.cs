using AegisSim.Core.Agents;
using AegisSim.Core.Mathematics;
using AegisSim.Core.Spatial;
using BenchmarkDotNet.Attributes;

namespace AegisSim.Benchmarks;

[MemoryDiagnoser]
public class SpatialHashBenchmarks
{
    private AgentManager _agentManager = null!;
    private SpatialHashGrid _spatialHash = null!;
    private Agent[] _agents = null!;

    [Params(200, 500, 1000)]
    public int AgentCount { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _agentManager = new AgentManager();

        for (int i = 0; i < AgentCount; i++)
        {
            var position = new Vector2(
                (i % 100) * 1.5,
                (i / 100) * 1.5);

            _agentManager.CreateAgent(position);
        }

        _agents = _agentManager.Agents.ToArray();
        _spatialHash = new SpatialHashGrid(cellSize: 2.0);
        _spatialHash.Rebuild(_agents);
    }

    [Benchmark]
    public void RebuildSpatialHash()
    {
        _spatialHash.Rebuild(_agents);
    }

    [Benchmark]
    public int QueryNearbyAgents()
    {
        int totalNeighbors = 0;

        foreach (Agent agent in _agents)
        {
            totalNeighbors += _spatialHash
                .Query(agent.Position, radius: 3.0)
                .Count;
        }

        return totalNeighbors;
    }
}