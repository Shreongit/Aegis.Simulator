
using System;
using System.Text;
using AegisSim.Core.Agents;
using AegisSim.Core.World;

namespace AegisSim.App.Rendering;

/// <summary>
/// Renders a grid-based simulation using terminal characters.
/// </summary>
public sealed class ConsoleRenderer
{
    private const char EmptyCell = '.';
    private const char WallCell = '#';
    private const char AgentCell = 'A';

    private readonly int _width;
    private readonly int _height;

    public ConsoleRenderer(int width, int height)
    {
        if (width <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(width));
        }

        if (height <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(height));
        }

        _width = width;
        _height = height;
    }

    /// <summary>
    /// Draws the world and agents in the terminal.
    /// </summary>
    public void Render(WorldMap world, AgentManager agentManager)
    {
        ArgumentNullException.ThrowIfNull(world);
        ArgumentNullException.ThrowIfNull(agentManager);

        if (world.Width != _width || world.Height != _height)
        {
            throw new ArgumentException(
                "Renderer dimensions must match world dimensions.",
                nameof(world));
        }

        var buffer = new char[_width * _height];

        Array.Fill(buffer, EmptyCell);

        for (int y = 0; y < _height; y++)
        {
            for (int x = 0; x < _width; x++)
            {
                if (!world.IsWalkable(x, y))
                {
                    buffer[y * _width + x] = WallCell;
                }
            }
        }

        foreach (Agent agent in agentManager.Agents)
        {
            int x = (int)Math.Floor(agent.Position.X);
            int y = (int)Math.Floor(agent.Position.Y);

            if (x >= 0 && y >= 0 && x < _width && y < _height)
            {
                buffer[y * _width + x] = AgentCell;
            }
        }

        var output = new StringBuilder(
            (_width + Environment.NewLine.Length) * _height);

        for (int y = 0; y < _height; y++)
        {
            output.Append(buffer, y * _width, _width);
            output.AppendLine();
        }

        Console.Write(output.ToString());
    }
}
