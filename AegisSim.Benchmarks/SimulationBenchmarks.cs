using AegisSim.Core.Agents;
using AegisSim.Core.Mathematics;
using BenchmarkDotNet.Attributes;

namespace AegisSim.Benchmarks;

[MemoryDiagnoser]
public class SimulationBenchmarks
{
    private AgentManager _agentManager = null!;
    private AgentSystem _agentSystem = null!;

    [Params(200, 500, 1000)]
    public int AgentCount { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _agentManager = new AgentManager();

        for (int i = 0; i < AgentCount; i++)
        {
            var position = new Vector2(
                i % 100,
                i / 100);

            Agent agent = _agentManager.CreateAgent(position);

            agent.SetDestination(
                new Vector2(
                    position.X + 10,
                    position.Y + 10));
        }

        _agentSystem = new AgentSystem(_agentManager);
    }

    [Benchmark]
    public void UpdateAgents()
    {
        _agentSystem.Update(1.0 / 30.0);
    }
}