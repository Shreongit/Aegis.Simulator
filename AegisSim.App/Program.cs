using System.Diagnostics;
using AegisSim.Core.Agents;
using AegisSim.Core.Simulation;
using AegisSim.Core.World;
using AegisSim.App.Rendering;

namespace AegisSim.App;

internal static class Program
{
private static void Main()
{
Console.Title = "Aegis-Sim";

    var settings = new SimulationSettings();
    settings.Validate();

    var world = new WorldMap(
        settings.WorldWidth,
        settings.WorldHeight);

    var agents = new AgentManager();
    var agentSystem = new AgentSystem(agents);
    var clock = new SimulationClock();
    var renderer = new WorldRenderer(world.Width, world.Height);

    SpawnInitialAgents(world, agents, settings.InitialAgentCount);

    Console.WriteLine("================================");
    Console.WriteLine("          AEGIS-SIM");
    Console.WriteLine("================================");
    Console.WriteLine($"World: {world.Width} x {world.Height}");
    Console.WriteLine($"Tick rate: {SimulationClock.TargetTickRate} Hz");
    Console.WriteLine($"Agents: {agents.Agents.Count}");
    Console.WriteLine("Press Q or Escape to quit.");
    Console.WriteLine();

    var stopwatch = Stopwatch.StartNew();
    double previousTime = stopwatch.Elapsed.TotalSeconds;
    double renderAccumulator = 0.0;
    const double renderInterval = 1.0 / 10.0;
    bool running = true;

    while (running)
    {
        double currentTime = stopwatch.Elapsed.TotalSeconds;
        double elapsedTime = currentTime - previousTime;
        previousTime = currentTime;

        int ticksToRun = clock.Advance(elapsedTime);

        for (int i = 0; i < ticksToRun; i++)
        {
            agentSystem.Update(SimulationClock.TargetTickTime);
        }

        renderAccumulator += elapsedTime;

        while (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey(intercept: true).Key;

            if (key is ConsoleKey.Q or ConsoleKey.Escape)
            {
                running = false;
                break;
            }
        }

        if (renderAccumulator >= renderInterval)
        {
            renderAccumulator %= renderInterval;
            renderer.Render(world, agents);

            Console.WriteLine(
                $"Agents: {agents.Agents.Count} | " +
                $"Ticks: {clock.TotalTicks} | " +
                $"TPS target: {SimulationClock.TargetTickRate:0}");
        }

        Thread.Sleep(1);
    }

    Console.WriteLine();
    Console.WriteLine(
        $"Simulation stopped after {clock.TotalTicks} ticks.");
}

private static void SpawnInitialAgents(
    WorldMap world,
    AgentManager agents,
    int count)
{
    if (count == 0)
    {
        return;
    }

    for (int i = 0; i < count; i++)
    {
        int x = i % world.Width;
        int y = (i / world.Width) % world.Height;

        if (world.IsWalkable(x, y))
        {
            agents.CreateAgent(
                new AegisSim.Core.Mathematics.Vector2(
                    x + 0.5,
                    y + 0.5));
        }
    }
}

}