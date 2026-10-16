using System;
using AegisSim.Core.Agents;
using AegisSim.Core.World;

namespace AegisSim.App.Rendering;

/// <summary>
/// Coordinates rendering of the simulation world.
/// </summary>
public sealed class WorldRenderer
{
    private readonly ConsoleRenderer _consoleRenderer;

    public WorldRenderer(int width, int height)
    {
        _consoleRenderer = new ConsoleRenderer(width, height);
    }

    /// <summary>
    /// Renders the world and its agents.
    /// </summary>
    public void Render(WorldMap world, AgentManager agents)
    {
        ArgumentNullException.ThrowIfNull(world);
        ArgumentNullException.ThrowIfNull(agents);

        _consoleRenderer.Render(world, agents);
    }
}