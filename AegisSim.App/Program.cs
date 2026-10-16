using System;
using System.Diagnostics;
using System.Threading;
using AegisSim.App.Rendering;
using AegisSim.Core.Agents;
using AegisSim.Core.Mathematics;
using AegisSim.Core.Pathfinding;
using AegisSim.Core.Simulation;
using AegisSim.Core.World;

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

    int destinationX = world.Width - 3;
    int destinationY = world.Height - 3;

    var flowFieldBuilder = new FlowFieldBuilder(world);
    var (integrationField, flowField) = flowFieldBuilder.Build(
        destinationX,
        destinationY);

    agentSystem.SetFlowField(flowField);

    int reachableAgents = 0;
    int agentsWithDirection = 0;

    foreach (Agent agent in agents.Agents)
    {
        int cellX = (int)Math.Floor(agent.Position.X);
        int cellY = (int)Math.Floor(agent.Position.Y);

        if (integrationField.IsReachable(cellX, cellY))
        {
            reachableAgents++;
        }

        if (flowField.IsInside(cellX, cellY) &&
            flowField.GetDirection(cellX, cellY).LengthSquared > 0.0)
        {
            agentsWithDirection++;
        }
    }

    Console.WriteLine(
        $"Navigation diagnostics: reachable={reachableAgents}, " +
        $"withDirection={agentsWithDirection}");

    Vector2 destination = new(
        destinationX + 0.5,
        destinationY + 0.5);

    foreach (Agent agent in agents.Agents)
    {
        agent.SetDestination(destination);
    }

    Console.WriteLine("================================");
    Console.WriteLine("          AEGIS-SIM");
    Console.WriteLine("================================");
    Console.WriteLine($"World: {world.Width} x {world.Height}");
    Console.WriteLine($"Tick rate: {SimulationClock.TargetTickRate} Hz");
    Console.WriteLine($"Agents: {agents.Agents.Count}");
    Console.WriteLine($"Destination: ({destinationX}, {destinationY})");
    Console.WriteLine("Navigation: Flow field");
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

            Console.SetCursorPosition(0, 9);
            renderer.Render(world, agents);

            int arrivedAgents = 0;

            foreach (Agent agent in agents.Agents)
            {
                if (!agent.HasDestination)
                {
                    arrivedAgents++;
                }
            }

            Console.WriteLine(
                $"Agents: {agents.Agents.Count} | " +
                $"Arrived: {arrivedAgents} | " +
                $"Moving: {agents.Agents.Count - arrivedAgents} | " +
                $"Ticks: {clock.TotalTicks} | " +
                $"TPS target: {SimulationClock.TargetTickRate:0}   ");
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
                new Vector2(x + 0.5, y + 0.5));
        }
    }
}

}