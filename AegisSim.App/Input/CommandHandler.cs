
using System;
using AegisSim.Core.Agents;
using AegisSim.Core.Mathematics;
using AegisSim.Core.World;

namespace AegisSim.App.Input;

/// <summary>
/// Parses and executes text commands for Aegis-Sim.
/// </summary>
public sealed class CommandHandler
{
    private readonly AgentManager _agents;
    private readonly WorldMap _world;

    public bool IsQuitRequested { get; private set; }

    public CommandHandler(AgentManager agents, WorldMap world)
    {
        ArgumentNullException.ThrowIfNull(agents);
        ArgumentNullException.ThrowIfNull(world);

        _agents = agents;
        _world = world;
    }

    /// <summary>
    /// Executes a command entered by the user.
    /// </summary>
    public void Execute(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return;
        }

        string[] parts = input.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries |
            StringSplitOptions.TrimEntries);

        switch (parts[0].ToLowerInvariant())
        {
            case "help":
                PrintHelp();
                break;

            case "spawn":
                SpawnAgent(parts);
                break;

            case "target":
                SetTarget(parts);
                break;

            case "quit":
            case "exit":
                IsQuitRequested = true;
                break;

            default:
                Console.WriteLine("Unknown command. Type 'help'.");
                break;
        }
    }

    private void SpawnAgent(string[] parts)
    {
        if (parts.Length != 3 ||
            !int.TryParse(parts[1], out int x) ||
            !int.TryParse(parts[2], out int y))
        {
            Console.WriteLine("Usage: spawn <x> <y>");
            return;
        }

        if (!_world.IsWalkable(x, y))
        {
            Console.WriteLine("That position is outside the world or blocked.");
            return;
        }

        Agent agent = _agents.CreateAgent(new Vector2(x + 0.5, y + 0.5));

        Console.WriteLine($"Spawned agent {agent.Id} at ({x}, {y}).");
    }

    private void SetTarget(string[] parts)
    {
        if (parts.Length != 4 ||
            !int.TryParse(parts[1], out int id) ||
            !int.TryParse(parts[2], out int x) ||
            !int.TryParse(parts[3], out int y))
        {
            Console.WriteLine("Usage: target <agentId> <x> <y>");
            return;
        }

        if (!_world.IsWalkable(x, y))
        {
            Console.WriteLine("Target is outside the world or blocked.");
            return;
        }

        if (!_agents.TryGetAgent(id, out Agent? agent) || agent is null)
        {
            Console.WriteLine($"Agent {id} was not found.");
            return;
        }

        agent.SetDestination(new Vector2(x + 0.5, y + 0.5));

        Console.WriteLine($"Agent {id} target set to ({x}, {y}).");
    }

    private static void PrintHelp()
    {
        Console.WriteLine("Aegis-Sim commands:");
        Console.WriteLine("  help                 Show this help");
        Console.WriteLine("  spawn <x> <y>        Spawn an agent");
        Console.WriteLine("  target <id> <x> <y>  Set an agent's destination");
        Console.WriteLine("  quit                 Exit the application");
    }
}
